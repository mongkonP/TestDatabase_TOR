using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ChemAtom.frm
{
    public partial class frmMolecularMass : Form
    {
        public frmMolecularMass()
        {
            InitializeComponent();
        }

        private void elementBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.elementBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.elementsDataSet);

        }

        private void frmMolecularMass_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            // TODO: This line of code loads data into the 'elementsDataSet.Element' table. You can move, or remove it, as needed.
            this.elementTableAdapter.Fill(this.elementsDataSet.tblElements);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmElementTable form1 = new  frmElementTable();
            form1.ShowDialog();
            this.elementTableAdapter.Fill(this.elementsDataSet.tblElements);

        }
        class ElementCal
        {
            public string Symbol, Element; public double atomicMass; public int count;
            public ElementCal(string symbol, string elem, double atomicMass, int count)
            {
                Symbol = symbol;
                this.atomicMass = atomicMass;
                this.count = count;
                Element = elem;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string chemicalFormula = textBox1.Text;
            richTextBox1.Text = chemicalFormula + "\n\n";
            string[] resultFormula = chemicalFormula.Split('.');
            double massTotal = 0;
            List<ElementCal> elements = new List<ElementCal>();

            //สร้างฟังชั่นสำหรับคำนวณมวลโมเลกุลและจำนวนอะตอมของแต่ละธาตุ
            Action<string, int> CalMassAndAtoms = (f, p) =>
            {
                Regex elementRegex = new Regex(@"([A-Z][a-z]*)(\d*)");
                double tm = 0;

                MatchCollection matches = elementRegex.Matches(f);
                foreach (Match match in matches)
                {
                    string es = match.Groups[1].Value.Trim();
                    string ec = match.Groups[2].Value.Trim();
                    int elementCount = 1;
                    if (!string.IsNullOrEmpty(ec))
                    {
                        elementCount = int.Parse(ec);
                    }
                    this.elementTableAdapter.FillBySymbol(this.elementsDataSet.tblElements, es);
                    if (this.elementDataGridView.RowCount > 0)
                    {
                        double atomicMass = Convert.ToDouble(elementDataGridView[3, 0].Value);
                        string element = elementDataGridView[1, 0].Value.ToString();
                        tm += atomicMass * elementCount;

                        // เพิ่มหรืออัปเดตจำนวนอะตอมของแต่ละธาตุใน elements
                        ElementCal existingElement = elements.Find(el => el.Symbol == es);
                        if (existingElement != null)
                        {
                            existingElement.count += p * elementCount;
                        }
                        else
                        {
                            elements.Add(new ElementCal(es, element, atomicMass, p * elementCount));
                        }
                        massTotal += atomicMass * p * elementCount;
                    }
                }

            };

            foreach (string formula in resultFormula)
            {
                Match match = new Regex(@"^(\d+)?([A-Za-z0-9]*)$").Match(formula);
                int numberPrefix = 1;
                if (match.Success && int.TryParse(match.Groups[1].Value, out int parsedNumber))
                {
                    numberPrefix = parsedNumber;
                }
                string _formula = match.Success ? match.Groups[2].Value : "";
                CalMassAndAtoms(_formula, numberPrefix);

            }

            elements.ForEach(el =>
            {
                richTextBox1.Text += $"\n {el.Element} {el.count} atom = {el.count * el.atomicMass} " +
                $"about {Math.Round(el.count * el.atomicMass * 100 / massTotal, 3)} %";
                //massTotal += el.count * el.atomicMass;
            });

            richTextBox1.Text += "\n\n\nTotal Atomic Mass: " + massTotal.ToString();

        }
    }

}
