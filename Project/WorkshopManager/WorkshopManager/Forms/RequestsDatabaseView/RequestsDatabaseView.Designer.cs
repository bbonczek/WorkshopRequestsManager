﻿namespace WorkshopManager
{
    partial class Form1
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
            this.requestsGroupBox = new System.Windows.Forms.GroupBox();
            this.requestsGrid = new System.Windows.Forms.DataGridView();
            this.modifyRequestsGroupBox = new System.Windows.Forms.GroupBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.requestsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.requestsGrid)).BeginInit();
            this.modifyRequestsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // requestsGroupBox
            // 
            this.requestsGroupBox.Controls.Add(this.requestsGrid);
            this.requestsGroupBox.Location = new System.Drawing.Point(13, 13);
            this.requestsGroupBox.Name = "requestsGroupBox";
            this.requestsGroupBox.Size = new System.Drawing.Size(444, 285);
            this.requestsGroupBox.TabIndex = 0;
            this.requestsGroupBox.TabStop = false;
            this.requestsGroupBox.Text = "Requests";
            // 
            // requestsGrid
            // 
            this.requestsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.requestsGrid.Location = new System.Drawing.Point(7, 20);
            this.requestsGrid.Name = "requestsGrid";
            this.requestsGrid.Size = new System.Drawing.Size(431, 259);
            this.requestsGrid.TabIndex = 0;
            // 
            // modifyRequestsGroupBox
            // 
            this.modifyRequestsGroupBox.Controls.Add(this.deleteButton);
            this.modifyRequestsGroupBox.Controls.Add(this.editButton);
            this.modifyRequestsGroupBox.Controls.Add(this.addButton);
            this.modifyRequestsGroupBox.Location = new System.Drawing.Point(463, 33);
            this.modifyRequestsGroupBox.Name = "modifyRequestsGroupBox";
            this.modifyRequestsGroupBox.Size = new System.Drawing.Size(87, 109);
            this.modifyRequestsGroupBox.TabIndex = 4;
            this.modifyRequestsGroupBox.TabStop = false;
            this.modifyRequestsGroupBox.Text = "Modify";
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(6, 79);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 6;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(6, 49);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(75, 23);
            this.editButton.TabIndex = 5;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(6, 19);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 4;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 321);
            this.Controls.Add(this.modifyRequestsGroupBox);
            this.Controls.Add(this.requestsGroupBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.requestsGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.requestsGrid)).EndInit();
            this.modifyRequestsGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox requestsGroupBox;
        private System.Windows.Forms.DataGridView requestsGrid;
        private System.Windows.Forms.GroupBox modifyRequestsGroupBox;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button addButton;
    }
}

