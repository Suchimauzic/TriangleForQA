using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SideTriangle
{
    public partial class Main : Form
    {
        int sideA, sideB, sideC;
        string textOut = "Треугольник является ";  // Для вывода
        bool checkBtn = true; // true - проверить, false - Начать снова
        string[] kinds = {"равносторонним", "равнобедренным", "разносторонним"}; // Виды треугольников

        public Main()
        {
            InitializeComponent();
        }

        private void tbSide_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void Main_Load(object sender, EventArgs e)
        {
            labelOutput.Visible = false;
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            bool trEx = false;
            bool trIsos = false;
            checkBtn = !checkBtn;

            if (!checkBtn)
            {
                try
                {
                    sideA = Convert.ToInt32(tbSideA.Text);
                    sideB = Convert.ToInt32(tbSideB.Text);
                    sideC = Convert.ToInt32(tbSideC.Text);

                    if ((sideA <= 0) || (sideB <= 0) || (sideC <= 0))
                    {
                        MessageBox.Show("Сторон размера 0 и меньше не существует!", "Ошибка!", MessageBoxButtons.OK);
                        checkBtn = !checkBtn;
                        return;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Неверный ввод! Не оставляйте поля пустыми и используйте только числа!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    checkBtn = !checkBtn;
                    return;
                }

                btnMain.Text = "Начать снова";

                if (sideA + sideB > sideC)
                {
                    if (sideB + sideC > sideA)
                    {
                        if (sideA + sideC > sideB)
                        {
                            trEx = true;
                        }
                    }
                }

                if (trEx)
                {
                    if (sideA == sideB && sideA != sideC)       // Равнобедренный
                    {
                        labelOutput.Text = textOut + kinds[1];
                    }
                    else if (sideB == sideC && sideB != sideA)
                    {
                        labelOutput.Text = textOut + kinds[1];
                    }
                    else if (sideA == sideC && sideA != sideB)
                    {
                        labelOutput.Text = textOut + kinds[1];
                    }
                    else if (sideA == sideB && sideB == sideC)  // Равносторонний
                    {
                        labelOutput.Text = textOut + kinds[0];
                    }
                    else                                        // Разносторонний
                    {
                        labelOutput.Text = textOut + kinds[2];
                    }
                }
                else
                {
                    labelOutput.Text = "Такого треугольника не существует!";
                }
            }
            else
            {
                btnMain.Text = "Проверить";
                tbSideA.Clear();
                tbSideB.Clear();
                tbSideC.Clear();
            }

            // Если checkBtn = true, то будет ввод данных, если false, то вывод данных

            labelInput.Visible = checkBtn;
            tbSideA.Visible = tbSideA.Enabled = checkBtn;
            tbSideB.Visible = tbSideB.Enabled = checkBtn;
            tbSideC.Visible = tbSideC.Enabled = checkBtn;

            labelOutput.Visible = !checkBtn;
        }
    }
}
