
namespace ListsInWinForms
{
    partial class frmUsingLists
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
            this.btnNewNumbers = new System.Windows.Forms.Button();
            this.BtnSortNumbers = new System.Windows.Forms.Button();
            this.IstNumbers = new System.Windows.Forms.ListBox();
            this.IstHeroes = new System.Windows.Forms.ListBox();
            this.btnSortHeroes = new System.Windows.Forms.Button();
            this.btnNewHeroes = new System.Windows.Forms.Button();
            this.lblNumbers = new System.Windows.Forms.Label();
            this.lblHeroes = new System.Windows.Forms.Label();
            this.lblSelectNumber = new System.Windows.Forms.Label();
            this.btnRemoveNumber = new System.Windows.Forms.Button();
            this.btnRemoveAllNumbers = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblEnterHeroName = new System.Windows.Forms.Label();
            this.txtAddHero = new System.Windows.Forms.TextBox();
            this.btmAddHero = new System.Windows.Forms.Button();
            this.lblEnterHeroNameRemove = new System.Windows.Forms.Label();
            this.btnRemoveHero = new System.Windows.Forms.Button();
            this.txtRemoveHero = new System.Windows.Forms.TextBox();
            this.btnUppercase = new System.Windows.Forms.Button();
            this.btnLowercase = new System.Windows.Forms.Button();
            this.btnSortNumbersDown = new System.Windows.Forms.Button();
            this.btnSortHeroesDown = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNewNumbers
            // 
            this.btnNewNumbers.Location = new System.Drawing.Point(16, 53);
            this.btnNewNumbers.Name = "btnNewNumbers";
            this.btnNewNumbers.Size = new System.Drawing.Size(60, 23);
            this.btnNewNumbers.TabIndex = 0;
            this.btnNewNumbers.Text = "New List";
            this.btnNewNumbers.UseVisualStyleBackColor = true;
            this.btnNewNumbers.Click += new System.EventHandler(this.btnNewNumbers_Click);
            // 
            // BtnSortNumbers
            // 
            this.BtnSortNumbers.Location = new System.Drawing.Point(82, 53);
            this.BtnSortNumbers.Name = "BtnSortNumbers";
            this.BtnSortNumbers.Size = new System.Drawing.Size(60, 23);
            this.BtnSortNumbers.TabIndex = 1;
            this.BtnSortNumbers.Text = "Sort Up";
            this.BtnSortNumbers.UseVisualStyleBackColor = true;
            this.BtnSortNumbers.Click += new System.EventHandler(this.BtnSortNumbers_Click);
            // 
            // IstNumbers
            // 
            this.IstNumbers.FormattingEnabled = true;
            this.IstNumbers.Location = new System.Drawing.Point(16, 82);
            this.IstNumbers.Name = "IstNumbers";
            this.IstNumbers.Size = new System.Drawing.Size(192, 108);
            this.IstNumbers.TabIndex = 2;
            // 
            // IstHeroes
            // 
            this.IstHeroes.FormattingEnabled = true;
            this.IstHeroes.Location = new System.Drawing.Point(214, 82);
            this.IstHeroes.Name = "IstHeroes";
            this.IstHeroes.Size = new System.Drawing.Size(190, 108);
            this.IstHeroes.TabIndex = 5;
            // 
            // btnSortHeroes
            // 
            this.btnSortHeroes.Location = new System.Drawing.Point(280, 53);
            this.btnSortHeroes.Name = "btnSortHeroes";
            this.btnSortHeroes.Size = new System.Drawing.Size(60, 23);
            this.btnSortHeroes.TabIndex = 4;
            this.btnSortHeroes.Text = "Sort Up";
            this.btnSortHeroes.UseVisualStyleBackColor = true;
            this.btnSortHeroes.Click += new System.EventHandler(this.btnSortHeroes_Click);
            // 
            // btnNewHeroes
            // 
            this.btnNewHeroes.Location = new System.Drawing.Point(214, 53);
            this.btnNewHeroes.Name = "btnNewHeroes";
            this.btnNewHeroes.Size = new System.Drawing.Size(60, 23);
            this.btnNewHeroes.TabIndex = 3;
            this.btnNewHeroes.Text = "New List";
            this.btnNewHeroes.UseVisualStyleBackColor = true;
            this.btnNewHeroes.Click += new System.EventHandler(this.btnNewHeroes_Click);
            // 
            // lblNumbers
            // 
            this.lblNumbers.AutoSize = true;
            this.lblNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumbers.Location = new System.Drawing.Point(49, 25);
            this.lblNumbers.Name = "lblNumbers";
            this.lblNumbers.Size = new System.Drawing.Size(70, 16);
            this.lblNumbers.TabIndex = 6;
            this.lblNumbers.Text = "Numbers";
            // 
            // lblHeroes
            // 
            this.lblHeroes.AutoSize = true;
            this.lblHeroes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeroes.Location = new System.Drawing.Point(222, 25);
            this.lblHeroes.Name = "lblHeroes";
            this.lblHeroes.Size = new System.Drawing.Size(59, 16);
            this.lblHeroes.TabIndex = 7;
            this.lblHeroes.Text = "Heroes";
            // 
            // lblSelectNumber
            // 
            this.lblSelectNumber.AutoSize = true;
            this.lblSelectNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectNumber.Location = new System.Drawing.Point(13, 197);
            this.lblSelectNumber.Name = "lblSelectNumber";
            this.lblSelectNumber.Size = new System.Drawing.Size(154, 15);
            this.lblSelectNumber.TabIndex = 8;
            this.lblSelectNumber.Text = "Select a number to remove";
            // 
            // btnRemoveNumber
            // 
            this.btnRemoveNumber.Location = new System.Drawing.Point(13, 216);
            this.btnRemoveNumber.Name = "btnRemoveNumber";
            this.btnRemoveNumber.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveNumber.TabIndex = 9;
            this.btnRemoveNumber.Text = "Remove";
            this.btnRemoveNumber.UseVisualStyleBackColor = true;
            this.btnRemoveNumber.Click += new System.EventHandler(this.btnRemoveNumber_Click);
            // 
            // btnRemoveAllNumbers
            // 
            this.btnRemoveAllNumbers.Location = new System.Drawing.Point(94, 216);
            this.btnRemoveAllNumbers.Name = "btnRemoveAllNumbers";
            this.btnRemoveAllNumbers.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveAllNumbers.TabIndex = 10;
            this.btnRemoveAllNumbers.Text = "Remove All";
            this.btnRemoveAllNumbers.UseVisualStyleBackColor = true;
            this.btnRemoveAllNumbers.Click += new System.EventHandler(this.btnRemoveAllNumbers_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(13, 279);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(40, 13);
            this.lblStatus.TabIndex = 11;
            this.lblStatus.Text = "Status:";
            // 
            // lblEnterHeroName
            // 
            this.lblEnterHeroName.AutoSize = true;
            this.lblEnterHeroName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterHeroName.Location = new System.Drawing.Point(255, 197);
            this.lblEnterHeroName.Name = "lblEnterHeroName";
            this.lblEnterHeroName.Size = new System.Drawing.Size(149, 15);
            this.lblEnterHeroName.TabIndex = 12;
            this.lblEnterHeroName.Text = "Enter a hero name to add:";
            // 
            // txtAddHero
            // 
            this.txtAddHero.Location = new System.Drawing.Point(258, 218);
            this.txtAddHero.Name = "txtAddHero";
            this.txtAddHero.Size = new System.Drawing.Size(100, 20);
            this.txtAddHero.TabIndex = 13;
            // 
            // btmAddHero
            // 
            this.btmAddHero.Location = new System.Drawing.Point(364, 215);
            this.btmAddHero.Name = "btmAddHero";
            this.btmAddHero.Size = new System.Drawing.Size(44, 23);
            this.btmAddHero.TabIndex = 14;
            this.btmAddHero.Text = "Add";
            this.btmAddHero.UseVisualStyleBackColor = true;
            this.btmAddHero.Click += new System.EventHandler(this.btmAddHero_Click);
            // 
            // lblEnterHeroNameRemove
            // 
            this.lblEnterHeroNameRemove.AutoSize = true;
            this.lblEnterHeroNameRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterHeroNameRemove.Location = new System.Drawing.Point(255, 241);
            this.lblEnterHeroNameRemove.Name = "lblEnterHeroNameRemove";
            this.lblEnterHeroNameRemove.Size = new System.Drawing.Size(169, 15);
            this.lblEnterHeroNameRemove.TabIndex = 15;
            this.lblEnterHeroNameRemove.Text = "Enter a hero name to remove:";
            // 
            // btnRemoveHero
            // 
            this.btnRemoveHero.Location = new System.Drawing.Point(351, 256);
            this.btnRemoveHero.Name = "btnRemoveHero";
            this.btnRemoveHero.Size = new System.Drawing.Size(57, 23);
            this.btnRemoveHero.TabIndex = 17;
            this.btnRemoveHero.Text = "Remove";
            this.btnRemoveHero.UseVisualStyleBackColor = true;
            this.btnRemoveHero.Click += new System.EventHandler(this.btnRemoveHero_Click);
            // 
            // txtRemoveHero
            // 
            this.txtRemoveHero.Location = new System.Drawing.Point(258, 259);
            this.txtRemoveHero.Name = "txtRemoveHero";
            this.txtRemoveHero.Size = new System.Drawing.Size(87, 20);
            this.txtRemoveHero.TabIndex = 16;
            // 
            // btnUppercase
            // 
            this.btnUppercase.Location = new System.Drawing.Point(258, 286);
            this.btnUppercase.Name = "btnUppercase";
            this.btnUppercase.Size = new System.Drawing.Size(150, 23);
            this.btnUppercase.TabIndex = 18;
            this.btnUppercase.Text = "UPPERCASE HEROES";
            this.btnUppercase.UseVisualStyleBackColor = true;
            this.btnUppercase.Click += new System.EventHandler(this.btnUppercase_Click);
            // 
            // btnLowercase
            // 
            this.btnLowercase.Location = new System.Drawing.Point(259, 315);
            this.btnLowercase.Name = "btnLowercase";
            this.btnLowercase.Size = new System.Drawing.Size(150, 23);
            this.btnLowercase.TabIndex = 19;
            this.btnLowercase.Text = "lowercase heroes";
            this.btnLowercase.UseVisualStyleBackColor = true;
            this.btnLowercase.Click += new System.EventHandler(this.btnLowercase_Click);
            // 
            // btnSortNumbersDown
            // 
            this.btnSortNumbersDown.Location = new System.Drawing.Point(148, 53);
            this.btnSortNumbersDown.Name = "btnSortNumbersDown";
            this.btnSortNumbersDown.Size = new System.Drawing.Size(60, 23);
            this.btnSortNumbersDown.TabIndex = 20;
            this.btnSortNumbersDown.Text = "Sort Dwn";
            this.btnSortNumbersDown.UseVisualStyleBackColor = true;
            this.btnSortNumbersDown.Click += new System.EventHandler(this.btnSortDown_Click);
            // 
            // btnSortHeroesDown
            // 
            this.btnSortHeroesDown.Location = new System.Drawing.Point(346, 53);
            this.btnSortHeroesDown.Name = "btnSortHeroesDown";
            this.btnSortHeroesDown.Size = new System.Drawing.Size(60, 23);
            this.btnSortHeroesDown.TabIndex = 21;
            this.btnSortHeroesDown.Text = "Sort Dwn";
            this.btnSortHeroesDown.UseVisualStyleBackColor = true;
            this.btnSortHeroesDown.Click += new System.EventHandler(this.btnSortHeroesDown_Click);
            // 
            // frmUsingLists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 350);
            this.Controls.Add(this.btnSortHeroesDown);
            this.Controls.Add(this.btnSortNumbersDown);
            this.Controls.Add(this.btnLowercase);
            this.Controls.Add(this.btnUppercase);
            this.Controls.Add(this.btnRemoveHero);
            this.Controls.Add(this.txtRemoveHero);
            this.Controls.Add(this.lblEnterHeroNameRemove);
            this.Controls.Add(this.btmAddHero);
            this.Controls.Add(this.txtAddHero);
            this.Controls.Add(this.lblEnterHeroName);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnRemoveAllNumbers);
            this.Controls.Add(this.btnRemoveNumber);
            this.Controls.Add(this.lblSelectNumber);
            this.Controls.Add(this.lblHeroes);
            this.Controls.Add(this.lblNumbers);
            this.Controls.Add(this.IstHeroes);
            this.Controls.Add(this.btnSortHeroes);
            this.Controls.Add(this.btnNewHeroes);
            this.Controls.Add(this.IstNumbers);
            this.Controls.Add(this.BtnSortNumbers);
            this.Controls.Add(this.btnNewNumbers);
            this.Name = "frmUsingLists";
            this.Text = "Using Lists";
            this.Load += new System.EventHandler(this.frmUsingLists_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNewNumbers;
        private System.Windows.Forms.Button BtnSortNumbers;
        private System.Windows.Forms.ListBox IstNumbers;
        private System.Windows.Forms.ListBox IstHeroes;
        private System.Windows.Forms.Button btnSortHeroes;
        private System.Windows.Forms.Button btnNewHeroes;
        private System.Windows.Forms.Label lblNumbers;
        private System.Windows.Forms.Label lblHeroes;
        private System.Windows.Forms.Label lblSelectNumber;
        private System.Windows.Forms.Button btnRemoveNumber;
        private System.Windows.Forms.Button btnRemoveAllNumbers;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblEnterHeroName;
        private System.Windows.Forms.TextBox txtAddHero;
        private System.Windows.Forms.Button btmAddHero;
        private System.Windows.Forms.Label lblEnterHeroNameRemove;
        private System.Windows.Forms.Button btnRemoveHero;
        private System.Windows.Forms.TextBox txtRemoveHero;
        private System.Windows.Forms.Button btnUppercase;
        private System.Windows.Forms.Button btnLowercase;
        private System.Windows.Forms.Button btnSortNumbersDown;
        private System.Windows.Forms.Button btnSortHeroesDown;
    }
}

