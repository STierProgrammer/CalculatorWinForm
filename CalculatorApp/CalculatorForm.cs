using System.Data;

namespace CalculatorApp
{
    public partial class CalculatorForm : Form
    {
        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            resultTextBox.Text = "";
            fullText = "";
            expression.Clear();
        }

        private void NumberButton_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            fullText += btn.Text;
            resultTextBox.Text += btn.Text;
        }

        private void OperatorButton_Click(object sender, EventArgs e)
        {
            try
            {
                Button btn = (Button)sender;

                if (!string.IsNullOrEmpty(fullText))
                {
                    expression.Add(fullText);
                    fullText = "";
                }

                if (expression.Count > 0 && !double.TryParse(expression.Last(), out _))
                {
                    expression[expression.Count - 1] = btn.Text;
                    resultTextBox.Text = resultTextBox.Text.TrimEnd() + " " + btn.Text + " ";
                }
                else if (expression.Count > 0)
                {
                    expression.Add(btn.Text);
                    resultTextBox.Text += " " + btn.Text + " ";
                }
                else
                {
                    throw new InvalidExpressionException("Cannot start an expression with an operator!");
                }
            }
            catch (InvalidExpressionException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void BtnEquals_Click(object sender, EventArgs e)
        { 

            try
            {
                if (!string.IsNullOrEmpty(fullText))
                {
                    expression.Add(fullText);
                }

                if (expression.Count > 1 && double.TryParse(expression.Last(), out _))
                {
                    double result = EvaluateExpression(expression);

                    string resultString = result.ToString();
                    resultTextBox.Text = resultString;

                    expression.Clear();
                    expression.Add(resultString);  
                    fullText = "";
                }
                else
                {
                    throw new InvalidExpressionException("Cannot evaluate when there is an operator last in the stack!");
                }
            }
            catch (InvalidExpressionException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static double EvaluateExpression(List<string> expression)
        {
            Stack<double> values = new();
            Stack<string> operators = new();

            for (int i = 0; i < expression.Count; i++)
            {
                string token = expression[i];

                if (double.TryParse(token, out double num))
                {
                    values.Push(num);
                }
                else
                {
                    while (operators.Count > 0 && Precedence(token) <= Precedence(operators.Peek()))
                    {
                        double val2 = values.Pop();
                        double val1 = values.Pop();
                        string op = operators.Pop();

                        values.Push(ApplyOperation(val1, val2, op));
                    }

                    operators.Push(token);
                }
            }

            while (operators.Count > 0)
            {
                double val2 = values.Pop();
                double val1 = values.Pop();
                string op = operators.Pop();

                values.Push(ApplyOperation(val1, val2, op));
            }

            return values.Pop();
        }

        private static double ApplyOperation(double val1, double val2, string op) => op switch
        {
            "+" => val1 + val2,
            "-" => val1 - val2,
            "*" => val1 * val2,
            "/" => val1 / val2,

            _ => throw new InvalidOperationException("Unknown operator")
        };

        private static int Precedence(string op) => op switch
        {
            "+" or "-" => 1,
            "*" or "/" => 2,
            _ => 0,
        };
    }
}
