﻿namespace Cipher
{
    partial class mainWindow
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
            this.codedListBox = new System.Windows.Forms.ListBox();
            this.pairingsListBox = new System.Windows.Forms.ListBox();
            this.symbolGuess = new System.Windows.Forms.TextBox();
            this.letterGuess = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addPairButton = new System.Windows.Forms.Button();
            this.validateButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.loadCoded = new System.Windows.Forms.Button();
            this.loadCluesButton = new System.Windows.Forms.Button();
            this.loadDecodedButton = new System.Windows.Forms.Button();
            this.codedWordDialog = new System.Windows.Forms.OpenFileDialog();
            this.cluesDialog = new System.Windows.Forms.OpenFileDialog();
            this.decodedWordDialog = new System.Windows.Forms.OpenFileDialog();
            this.deletePairButton = new System.Windows.Forms.Button();
            this.frequencyList = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // codedListBox
            // 
            this.codedListBox.FormattingEnabled = true;
            this.codedListBox.Location = new System.Drawing.Point(13, 26);
            this.codedListBox.Name = "codedListBox";
            this.codedListBox.Size = new System.Drawing.Size(120, 238);
            this.codedListBox.TabIndex = 0;
            // 
            // pairingsListBox
            // 
            this.pairingsListBox.FormattingEnabled = true;
            this.pairingsListBox.Location = new System.Drawing.Point(139, 26);
            this.pairingsListBox.Name = "pairingsListBox";
            this.pairingsListBox.Size = new System.Drawing.Size(120, 238);
            this.pairingsListBox.TabIndex = 1;
            // 
            // symbolGuess
            // 
            this.symbolGuess.Location = new System.Drawing.Point(16, 297);
            this.symbolGuess.MaxLength = 1;
            this.symbolGuess.Name = "symbolGuess";
            this.symbolGuess.Size = new System.Drawing.Size(100, 20);
            this.symbolGuess.TabIndex = 2;
            // 
            // letterGuess
            // 
            this.letterGuess.Location = new System.Drawing.Point(139, 297);
            this.letterGuess.MaxLength = 1;
            this.letterGuess.Name = "letterGuess";
            this.letterGuess.Size = new System.Drawing.Size(100, 20);
            this.letterGuess.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 281);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Symbol:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 281);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Letter:";
            // 
            // addPairButton
            // 
            this.addPairButton.Location = new System.Drawing.Point(279, 273);
            this.addPairButton.Name = "addPairButton";
            this.addPairButton.Size = new System.Drawing.Size(142, 23);
            this.addPairButton.TabIndex = 6;
            this.addPairButton.Text = "Make Guess";
            this.addPairButton.UseVisualStyleBackColor = true;
            this.addPairButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // validateButton
            // 
            this.validateButton.Location = new System.Drawing.Point(279, 302);
            this.validateButton.Name = "validateButton";
            this.validateButton.Size = new System.Drawing.Size(142, 23);
            this.validateButton.TabIndex = 7;
            this.validateButton.Text = "Check Guesses";
            this.validateButton.UseVisualStyleBackColor = true;
            this.validateButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Coded Words:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(136, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Pairings:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(122, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "->";
            // 
            // loadCoded
            // 
            this.loadCoded.Location = new System.Drawing.Point(442, 244);
            this.loadCoded.Name = "loadCoded";
            this.loadCoded.Size = new System.Drawing.Size(120, 23);
            this.loadCoded.TabIndex = 11;
            this.loadCoded.Text = "Load Coded Words";
            this.loadCoded.UseVisualStyleBackColor = true;
            this.loadCoded.Click += new System.EventHandler(this.button3_Click);
            // 
            // loadCluesButton
            // 
            this.loadCluesButton.Location = new System.Drawing.Point(442, 273);
            this.loadCluesButton.Name = "loadCluesButton";
            this.loadCluesButton.Size = new System.Drawing.Size(120, 23);
            this.loadCluesButton.TabIndex = 12;
            this.loadCluesButton.Text = "Load Clues";
            this.loadCluesButton.UseVisualStyleBackColor = true;
            this.loadCluesButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // loadDecodedButton
            // 
            this.loadDecodedButton.Location = new System.Drawing.Point(442, 302);
            this.loadDecodedButton.Name = "loadDecodedButton";
            this.loadDecodedButton.Size = new System.Drawing.Size(120, 23);
            this.loadDecodedButton.TabIndex = 13;
            this.loadDecodedButton.Text = "Load Decoded Words";
            this.loadDecodedButton.UseVisualStyleBackColor = true;
            this.loadDecodedButton.Click += new System.EventHandler(this.button5_Click);
            // 
            // codedWordDialog
            // 
            this.codedWordDialog.Filter = "Text files (*.txt)|*.txt";
            // 
            // cluesDialog
            // 
            this.cluesDialog.Filter = "Text files (*.txt)|*.txt";
            // 
            // decodedWordDialog
            // 
            this.decodedWordDialog.Filter = "Text files (*.txt)|*.txt";
            // 
            // deletePairButton
            // 
            this.deletePairButton.Location = new System.Drawing.Point(279, 244);
            this.deletePairButton.Name = "deletePairButton";
            this.deletePairButton.Size = new System.Drawing.Size(142, 23);
            this.deletePairButton.TabIndex = 14;
            this.deletePairButton.Text = "Delete Selected Pairing";
            this.deletePairButton.UseVisualStyleBackColor = true;
            this.deletePairButton.Click += new System.EventHandler(this.deletePairButton_Click);
            // 
            // frequencyList
            // 
            this.frequencyList.FormattingEnabled = true;
            this.frequencyList.Location = new System.Drawing.Point(442, 26);
            this.frequencyList.Name = "frequencyList";
            this.frequencyList.Size = new System.Drawing.Size(120, 212);
            this.frequencyList.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(439, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Symbol Frequency:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(315, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Note: please load coded";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(316, 225);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "words before clues";
            // 
            // mainWindow
            // 
            this.AcceptButton = this.addPairButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 329);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.frequencyList);
            this.Controls.Add(this.deletePairButton);
            this.Controls.Add(this.loadDecodedButton);
            this.Controls.Add(this.loadCluesButton);
            this.Controls.Add(this.loadCoded);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.validateButton);
            this.Controls.Add(this.addPairButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.letterGuess);
            this.Controls.Add(this.symbolGuess);
            this.Controls.Add(this.pairingsListBox);
            this.Controls.Add(this.codedListBox);
            this.Name = "mainWindow";
            this.Text = "Cipher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox codedListBox;
        private System.Windows.Forms.ListBox pairingsListBox;
        private System.Windows.Forms.TextBox symbolGuess;
        private System.Windows.Forms.TextBox letterGuess;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addPairButton;
        private System.Windows.Forms.Button validateButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button loadCoded;
        private System.Windows.Forms.Button loadCluesButton;
        private System.Windows.Forms.Button loadDecodedButton;
        private System.Windows.Forms.OpenFileDialog codedWordDialog;
        private System.Windows.Forms.OpenFileDialog cluesDialog;
        private System.Windows.Forms.OpenFileDialog decodedWordDialog;
        private System.Windows.Forms.Button deletePairButton;
        private System.Windows.Forms.ListBox frequencyList;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
    }
}

