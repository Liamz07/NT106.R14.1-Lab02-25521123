using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace LAB2
{
    public partial class ucBai3 : UserControl
    {
        public ucBai3()
        {
            InitializeComponent();
        }

        private void btnDocFile_Click(object sender, EventArgs e)
        {
            string filePath = "input3.txt";
            if (File.Exists(filePath))
            {
                rtbContent.Text = File.ReadAllText(filePath);
            }
            else
            {
                MessageBox.Show("Không tìm thấy file input3.txt!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGhiFile_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(rtbContent.Text))
            {
                MessageBox.Show("Chưa có nội dung để ghi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                File.WriteAllText("output3.txt", rtbContent.Text);
                MessageBox.Show("Đã ghi kết quả thành công vào file 'output3.txt'!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi file: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTinhToan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(rtbContent.Text))
            {
                MessageBox.Show("Chưa có nội dung để tính toán!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                string[] lines = rtbContent.Lines;
                List<string> resultLines = new List<string>();
                foreach (string line in lines)
                {
                    if (string.IsNullOrWhiteSpace(line)) continue;
                    try
                    {
                        string expression = line;
                        if (expression.Contains("="))
                        {
                            expression = expression.Split('=')[0];
                        }
                        double result = EvaluateExpression(expression);
                        resultLines.Add($"{expression.Trim()} = {result}");
                    }
                    catch (Exception)
                    {
                        resultLines.Add($"{line.Trim()} = Lỗi biểu thức");
                    }
                }
                rtbContent.Text = string.Join(Environment.NewLine, resultLines);
                MessageBox.Show("Tính toán hoàn tất!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region Hàm hỗ trợ tính toán biểu thức (Shunting-yard Algorithm)

        private double EvaluateExpression(string expression)
        {
            List<string> tokens = Tokenize(expression);
            List<string> postfix = InfixToPostfix(tokens);
            return EvaluatePostfix(postfix);
        }

        private List<string> Tokenize(string expr)
        {
            List<string> tokens = new List<string>();
            string numberBuffer = "";
            for (int i = 0; i < expr.Length; i++)
            {
                char c = expr[i];
                if (char.IsWhiteSpace(c)) continue;
                if (char.IsDigit(c) || c == '.')
                {
                    numberBuffer += c;
                }
                else
                {
                    if (numberBuffer.Length > 0)
                    {
                        tokens.Add(numberBuffer);
                        numberBuffer = "";
                    }
                    if (c == '-')
                    {
                        bool isUnary = (tokens.Count == 0 || tokens[tokens.Count - 1] == "(" || IsOperator(tokens[tokens.Count - 1][0]));
                        if (isUnary)
                        {
                            numberBuffer += c;
                            continue;
                        }
                    }
                    if ("+-*/()".Contains(c.ToString()))
                    {
                        tokens.Add(c.ToString());
                    }
                }
            }
            if (numberBuffer.Length > 0)
            {
                tokens.Add(numberBuffer);
            }

            return tokens;
        }
        private List<string> InfixToPostfix(List<string> tokens)
        {
            List<string> output = new List<string>();
            Stack<string> operators = new Stack<string>();
            foreach (string token in tokens)
            {
                if (double.TryParse(token, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out _))
                {
                    output.Add(token);
                }
                else if (token == "(")
                {
                    operators.Push(token);
                }
                else if (token == ")")
                {
                    while (operators.Count > 0 && operators.Peek() != "(")
                    {
                        output.Add(operators.Pop());
                    }
                    if (operators.Count > 0 && operators.Peek() == "(")
                    {
                        operators.Pop();
                    }
                }
                else if (IsOperator(token[0]))
                {
                    while (operators.Count > 0 && IsOperator(operators.Peek()[0]) && GetPrecedence(operators.Peek()[0]) >= GetPrecedence(token[0]))
                    {
                        output.Add(operators.Pop());
                    }
                    operators.Push(token);
                }
            }
            while (operators.Count > 0)
            {
                output.Add(operators.Pop());
            }

            return output;
        }

        private double EvaluatePostfix(List<string> postfix)
        {
            Stack<double> stack = new Stack<double>();
            foreach (string token in postfix)
            {
                if (double.TryParse(token, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out double value))
                {
                    stack.Push(value);
                }
                else if (IsOperator(token[0]))
                {
                    if (stack.Count < 2) throw new InvalidOperationException("Biểu thức không hợp lệ");
                    double b = stack.Pop();
                    double a = stack.Pop();
                    switch (token[0])
                    {
                        case '+': stack.Push(a + b); break;
                        case '-': stack.Push(a - b); break;
                        case '*': stack.Push(a * b); break;
                        case '/':
                            if (b == 0) throw new DivideByZeroException("Lỗi chia cho 0");
                            stack.Push(a / b);
                            break;
                    }
                }
            }
            return stack.Count > 0 ? stack.Pop() : 0;
        }

        private bool IsOperator(char c)
        {
            return c == '+' || c == '-' || c == '*' || c == '/';
        }

        private int GetPrecedence(char op)
        {
            if (op == '+' || op == '-') return 1;
            if (op == '*' || op == '/') return 2;
            return 0;
        }

        #endregion

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Control parent = this.Parent;
            if (parent != null)
            {
                parent.Controls.Remove(this);
                this.Dispose();
            }
        }
    }
}
