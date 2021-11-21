using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Xsl;

namespace DataProcessing
{
    public partial class Form : System.Windows.Forms.Form
    {
        string path = @"C:\Users\Юлия\Desktop\ООП\ЛАБА2\DataProcessing\DataProcessing\XMLFileSerials.xml";
        List<Serial> final = new List<Serial>();
        public Form()
        {
            InitializeComponent();
            fillComboBoxes(path);

        }

        private void fillComboBoxes(string path)
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(path);//відкриття файлу, з яким працюватимемо

            XmlElement xRoot = xDoc.DocumentElement; //получаем корневой элемент <Serials>
            foreach (XmlElement xnode in xRoot) //обходим все узлы <Serial> </Serial>
            {
                addComponenttoConcreteComboBox(xnode);
            }
            comboBoxReleased.Items.Add("Old (< 2005)");
            comboBoxReleased.Items.Add("Recent (2006 - 2015)");
            comboBoxReleased.Items.Add("New (2016 - 2021)");

            comboBoxSeasons.Items.Add("Small (1-3)");
            comboBoxSeasons.Items.Add("Medium (4-7)");
            comboBoxSeasons.Items.Add("Large (8+)");

            comboBoxRating.Items.Add("Bad (1-2)");
            comboBoxRating.Items.Add("Satisfactorily (3-4)");
            comboBoxRating.Items.Add("Good (4-5)");
        }
        private void addComponenttoConcreteComboBox(XmlElement xnode) //country, genre
        {
            XmlNode attr = xnode.Attributes.GetNamedItem("Genre");
            if(!comboBoxGenre.Items.Contains(attr.Value))
                comboBoxGenre.Items.Add(attr.Value);

            attr = xnode.Attributes.GetNamedItem("Country");
            if (!comboBoxCountry.Items.Contains(attr.Value))
                comboBoxCountry.Items.Add(attr.Value);
        }
        private void richTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxName_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxCountry.Enabled = checkBoxCountry.Checked;
        }
        private bool isYearRange(XmlNode year)
        {
            return true;
        }
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            search();
        }
        private void search()
        {
            richTextBox.Clear();
            Serial _serial = OurSerialInfo();
            if(radioButtonLINQ.Checked)
            {
                IAnalizatorXMLStrategy CurrentStrategy = new LINQ(path);
                final = CurrentStrategy.Search(_serial);
                Output(final);
            }
            if(radioButtonDOM.Checked)
            {
                IAnalizatorXMLStrategy CurrentStrategy = new DOM(path);
                final = CurrentStrategy.Search(_serial);
                Output(final);
            }
            if(radioButtonSAX.Checked)
            {
                IAnalizatorXMLStrategy CurrentStrategy = new SAX(path);
                final = CurrentStrategy.Search(_serial);
                Output(final);
            }
        }
        private Serial OurSerialInfo()
        {
            Serial IdealSerial = new Serial();
            if (checkBoxGenre.Checked) IdealSerial.Genre = Convert.ToString(comboBoxGenre.Text);
            if (checkBoxReleased.Checked) IdealSerial.Released = Convert.ToString(comboBoxReleased.Text);
            if (checkBoxRating.Checked) IdealSerial.Rating = Convert.ToString(comboBoxRating.Text);
            if (checkBoxSeasons.Checked) IdealSerial.Seasons = Convert.ToString(comboBoxSeasons.Text);
            if (checkBoxCountry.Checked) IdealSerial.Country = Convert.ToString(comboBoxCountry.Text);

            return IdealSerial;
        }
        private void Output(List<Serial> final)
        {
            int i = 1;
            Console.WriteLine("Alg+");
            foreach(Serial serial in final)
            {
                richTextBox.AppendText(i++ + "." + "\n");
                richTextBox.AppendText("Name: "+serial.Name+"\n");
                richTextBox.AppendText("Genre: " + serial.Genre + "\n");
                richTextBox.AppendText("Released in: " + serial.Released + "\n");
                richTextBox.AppendText("Rating: " + serial.Rating + "\n");
                richTextBox.AppendText("Seasons: " + serial.Seasons + "\n");
                richTextBox.AppendText("Country: " + serial.Country + "\n");
            }
        }

        
        private void checkBoxGenre_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxGenre.Enabled = checkBoxGenre.Checked;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            richTextBox.Clear();
            checkBoxGenre.Checked = false;
            checkBoxReleased.Checked = false;
            checkBoxRating.Checked = false;
            checkBoxSeasons.Checked = false;
            checkBoxCountry.Checked = false;
            radioButtonDOM.Checked = false;
            radioButtonLINQ.Checked = false;
            radioButtonSAX.Checked = false;
            comboBoxGenre.Text = null;
            comboBoxReleased.Text = null;
            comboBoxRating.Text = null;
            comboBoxSeasons.Text = null;
            comboBoxCountry.Text = null;
        }

        private void checkBoxReleased_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxReleased.Enabled = checkBoxReleased.Checked;
        }

        private void checkBoxRating_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxRating.Enabled = checkBoxRating.Checked;
        }

        private void checkBoxSeasons_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxSeasons.Enabled = checkBoxSeasons.Checked;
        }

        private void buttonTransformHTML_Click(object sender, EventArgs e)
        {
            transform();
            MessageBox.Show("Successfully completed");
        }
        private void transform()
        {
            XslCompiledTransform xct = new XslCompiledTransform();
            xct.Load(@"C:\Users\Юлия\Desktop\ООП\ЛАБА2\DataProcessing\DataProcessing\bin\Debug\Serials.xsl");
            string fXML = @"C:\Users\Юлия\Desktop\ООП\ЛАБА2\DataProcessing\DataProcessing\XMLFileSerials.xml";
            string fHTML = @"C:\Users\Юлия\Desktop\ООП\ЛАБА2\DataProcessing\DataProcessing\bin\Debug\Serials.html";
            xct.Transform(fXML, fHTML);
        }
    }
}
