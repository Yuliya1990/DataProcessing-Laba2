
namespace DataProcessing
{
    partial class Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.checkBoxCountry = new System.Windows.Forms.CheckBox();
            this.checkBoxGenre = new System.Windows.Forms.CheckBox();
            this.checkBoxReleased = new System.Windows.Forms.CheckBox();
            this.checkBoxRating = new System.Windows.Forms.CheckBox();
            this.checkBoxSeasons = new System.Windows.Forms.CheckBox();
            this.comboBoxGenre = new System.Windows.Forms.ComboBox();
            this.comboBoxReleased = new System.Windows.Forms.ComboBox();
            this.comboBoxRating = new System.Windows.Forms.ComboBox();
            this.comboBoxSeasons = new System.Windows.Forms.ComboBox();
            this.comboBoxCountry = new System.Windows.Forms.ComboBox();
            this.radioButtonLINQ = new System.Windows.Forms.RadioButton();
            this.radioButtonDOM = new System.Windows.Forms.RadioButton();
            this.radioButtonSAX = new System.Windows.Forms.RadioButton();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonTransformHTML = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox
            // 
            this.richTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox.Location = new System.Drawing.Point(495, 12);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(371, 470);
            this.richTextBox.TabIndex = 0;
            this.richTextBox.Text = "";
            this.richTextBox.TextChanged += new System.EventHandler(this.richTextBox_TextChanged);
            // 
            // checkBoxCountry
            // 
            this.checkBoxCountry.AutoSize = true;
            this.checkBoxCountry.Location = new System.Drawing.Point(23, 192);
            this.checkBoxCountry.Name = "checkBoxCountry";
            this.checkBoxCountry.Size = new System.Drawing.Size(90, 24);
            this.checkBoxCountry.TabIndex = 2;
            this.checkBoxCountry.Text = "Country";
            this.checkBoxCountry.UseVisualStyleBackColor = true;
            this.checkBoxCountry.CheckedChanged += new System.EventHandler(this.checkBoxName_CheckedChanged);
            // 
            // checkBoxGenre
            // 
            this.checkBoxGenre.AutoSize = true;
            this.checkBoxGenre.Location = new System.Drawing.Point(23, 34);
            this.checkBoxGenre.Name = "checkBoxGenre";
            this.checkBoxGenre.Size = new System.Drawing.Size(80, 24);
            this.checkBoxGenre.TabIndex = 3;
            this.checkBoxGenre.Text = "Genre";
            this.checkBoxGenre.UseVisualStyleBackColor = true;
            this.checkBoxGenre.CheckedChanged += new System.EventHandler(this.checkBoxGenre_CheckedChanged);
            // 
            // checkBoxReleased
            // 
            this.checkBoxReleased.AutoSize = true;
            this.checkBoxReleased.Location = new System.Drawing.Point(23, 74);
            this.checkBoxReleased.Name = "checkBoxReleased";
            this.checkBoxReleased.Size = new System.Drawing.Size(103, 24);
            this.checkBoxReleased.TabIndex = 4;
            this.checkBoxReleased.Text = "Released";
            this.checkBoxReleased.UseVisualStyleBackColor = true;
            this.checkBoxReleased.CheckedChanged += new System.EventHandler(this.checkBoxReleased_CheckedChanged);
            // 
            // checkBoxRating
            // 
            this.checkBoxRating.AutoSize = true;
            this.checkBoxRating.Location = new System.Drawing.Point(23, 113);
            this.checkBoxRating.Name = "checkBoxRating";
            this.checkBoxRating.Size = new System.Drawing.Size(82, 24);
            this.checkBoxRating.TabIndex = 5;
            this.checkBoxRating.Text = "Rating";
            this.checkBoxRating.UseVisualStyleBackColor = true;
            this.checkBoxRating.CheckedChanged += new System.EventHandler(this.checkBoxRating_CheckedChanged);
            // 
            // checkBoxSeasons
            // 
            this.checkBoxSeasons.AutoSize = true;
            this.checkBoxSeasons.Location = new System.Drawing.Point(23, 153);
            this.checkBoxSeasons.Name = "checkBoxSeasons";
            this.checkBoxSeasons.Size = new System.Drawing.Size(173, 24);
            this.checkBoxSeasons.TabIndex = 6;
            this.checkBoxSeasons.Text = "Number of seasons";
            this.checkBoxSeasons.UseVisualStyleBackColor = true;
            this.checkBoxSeasons.CheckedChanged += new System.EventHandler(this.checkBoxSeasons_CheckedChanged);
            // 
            // comboBoxGenre
            // 
            this.comboBoxGenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGenre.Enabled = false;
            this.comboBoxGenre.FormattingEnabled = true;
            this.comboBoxGenre.Location = new System.Drawing.Point(258, 30);
            this.comboBoxGenre.Name = "comboBoxGenre";
            this.comboBoxGenre.Size = new System.Drawing.Size(173, 28);
            this.comboBoxGenre.TabIndex = 7;
            // 
            // comboBoxReleased
            // 
            this.comboBoxReleased.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxReleased.Enabled = false;
            this.comboBoxReleased.FormattingEnabled = true;
            this.comboBoxReleased.Location = new System.Drawing.Point(258, 74);
            this.comboBoxReleased.Name = "comboBoxReleased";
            this.comboBoxReleased.Size = new System.Drawing.Size(173, 28);
            this.comboBoxReleased.TabIndex = 8;
            // 
            // comboBoxRating
            // 
            this.comboBoxRating.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRating.Enabled = false;
            this.comboBoxRating.FormattingEnabled = true;
            this.comboBoxRating.Location = new System.Drawing.Point(258, 113);
            this.comboBoxRating.Name = "comboBoxRating";
            this.comboBoxRating.Size = new System.Drawing.Size(173, 28);
            this.comboBoxRating.TabIndex = 9;
            // 
            // comboBoxSeasons
            // 
            this.comboBoxSeasons.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSeasons.Enabled = false;
            this.comboBoxSeasons.FormattingEnabled = true;
            this.comboBoxSeasons.Location = new System.Drawing.Point(258, 153);
            this.comboBoxSeasons.Name = "comboBoxSeasons";
            this.comboBoxSeasons.Size = new System.Drawing.Size(173, 28);
            this.comboBoxSeasons.TabIndex = 10;
            // 
            // comboBoxCountry
            // 
            this.comboBoxCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCountry.Enabled = false;
            this.comboBoxCountry.FormattingEnabled = true;
            this.comboBoxCountry.Location = new System.Drawing.Point(258, 192);
            this.comboBoxCountry.Name = "comboBoxCountry";
            this.comboBoxCountry.Size = new System.Drawing.Size(173, 28);
            this.comboBoxCountry.TabIndex = 11;
            // 
            // radioButtonLINQ
            // 
            this.radioButtonLINQ.AutoSize = true;
            this.radioButtonLINQ.Location = new System.Drawing.Point(23, 271);
            this.radioButtonLINQ.Name = "radioButtonLINQ";
            this.radioButtonLINQ.Size = new System.Drawing.Size(71, 24);
            this.radioButtonLINQ.TabIndex = 12;
            this.radioButtonLINQ.TabStop = true;
            this.radioButtonLINQ.Text = "LINQ";
            this.radioButtonLINQ.UseVisualStyleBackColor = true;
            // 
            // radioButtonDOM
            // 
            this.radioButtonDOM.AutoSize = true;
            this.radioButtonDOM.Location = new System.Drawing.Point(175, 271);
            this.radioButtonDOM.Name = "radioButtonDOM";
            this.radioButtonDOM.Size = new System.Drawing.Size(71, 24);
            this.radioButtonDOM.TabIndex = 13;
            this.radioButtonDOM.TabStop = true;
            this.radioButtonDOM.Text = "DOM";
            this.radioButtonDOM.UseVisualStyleBackColor = true;
            // 
            // radioButtonSAX
            // 
            this.radioButtonSAX.AutoSize = true;
            this.radioButtonSAX.Location = new System.Drawing.Point(312, 271);
            this.radioButtonSAX.Name = "radioButtonSAX";
            this.radioButtonSAX.Size = new System.Drawing.Size(67, 24);
            this.radioButtonSAX.TabIndex = 14;
            this.radioButtonSAX.TabStop = true;
            this.radioButtonSAX.Text = "SAX";
            this.radioButtonSAX.UseVisualStyleBackColor = true;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(123, 311);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(153, 35);
            this.buttonSearch.TabIndex = 15;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonTransformHTML
            // 
            this.buttonTransformHTML.Location = new System.Drawing.Point(42, 374);
            this.buttonTransformHTML.Name = "buttonTransformHTML";
            this.buttonTransformHTML.Size = new System.Drawing.Size(130, 45);
            this.buttonTransformHTML.TabIndex = 17;
            this.buttonTransformHTML.Text = "HTML";
            this.buttonTransformHTML.UseVisualStyleBackColor = true;
            this.buttonTransformHTML.Click += new System.EventHandler(this.buttonTransformHTML_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(222, 374);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(130, 45);
            this.buttonClear.TabIndex = 18;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 494);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonTransformHTML);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.radioButtonSAX);
            this.Controls.Add(this.radioButtonDOM);
            this.Controls.Add(this.radioButtonLINQ);
            this.Controls.Add(this.comboBoxCountry);
            this.Controls.Add(this.comboBoxSeasons);
            this.Controls.Add(this.comboBoxRating);
            this.Controls.Add(this.comboBoxReleased);
            this.Controls.Add(this.comboBoxGenre);
            this.Controls.Add(this.checkBoxSeasons);
            this.Controls.Add(this.checkBoxRating);
            this.Controls.Add(this.checkBoxReleased);
            this.Controls.Add(this.checkBoxGenre);
            this.Controls.Add(this.checkBoxCountry);
            this.Controls.Add(this.richTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form";
            this.Text = "Data";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.CheckBox checkBoxCountry;
        private System.Windows.Forms.CheckBox checkBoxGenre;
        private System.Windows.Forms.CheckBox checkBoxReleased;
        private System.Windows.Forms.CheckBox checkBoxRating;
        private System.Windows.Forms.CheckBox checkBoxSeasons;
        private System.Windows.Forms.ComboBox comboBoxGenre;
        private System.Windows.Forms.ComboBox comboBoxReleased;
        private System.Windows.Forms.ComboBox comboBoxRating;
        private System.Windows.Forms.ComboBox comboBoxSeasons;
        private System.Windows.Forms.ComboBox comboBoxCountry;
        private System.Windows.Forms.RadioButton radioButtonLINQ;
        private System.Windows.Forms.RadioButton radioButtonDOM;
        private System.Windows.Forms.RadioButton radioButtonSAX;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonTransformHTML;
        private System.Windows.Forms.Button buttonClear;
    }
}

