﻿namespace EinfachesCRUD
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
    protected override void Dispose( bool disposing )
      {
      if ( disposing && ( components != null ) )
        {
        components.Dispose();
        }
      base.Dispose( disposing );
      }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
      {
      this.txtName = new System.Windows.Forms.TextBox();
      this.btnAdd = new System.Windows.Forms.Button();
      this.btnUpdate = new System.Windows.Forms.Button();
      this.btnDelete = new System.Windows.Forms.Button();
      this.btnRead = new System.Windows.Forms.Button();
      this.dataGridViewStudents = new System.Windows.Forms.DataGridView();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).BeginInit();
      this.SuspendLayout();
      // 
      // txtName
      // 
      this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
      this.txtName.Location = new System.Drawing.Point(48, 40);
      this.txtName.Name = "txtName";
      this.txtName.Size = new System.Drawing.Size(100, 34);
      this.txtName.TabIndex = 0;
      // 
      // btnAdd
      // 
      this.btnAdd.Location = new System.Drawing.Point(181, 30);
      this.btnAdd.Name = "btnAdd";
      this.btnAdd.Size = new System.Drawing.Size(138, 44);
      this.btnAdd.TabIndex = 1;
      this.btnAdd.Text = "Hinzufügen";
      this.btnAdd.UseVisualStyleBackColor = true;
      this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
      // 
      // btnUpdate
      // 
      this.btnUpdate.Location = new System.Drawing.Point(334, 30);
      this.btnUpdate.Name = "btnUpdate";
      this.btnUpdate.Size = new System.Drawing.Size(138, 44);
      this.btnUpdate.TabIndex = 2;
      this.btnUpdate.Text = "Aktualisieren";
      this.btnUpdate.UseVisualStyleBackColor = true;
      this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
      // 
      // btnDelete
      // 
      this.btnDelete.Location = new System.Drawing.Point(478, 30);
      this.btnDelete.Name = "btnDelete";
      this.btnDelete.Size = new System.Drawing.Size(130, 44);
      this.btnDelete.TabIndex = 3;
      this.btnDelete.Text = "Löschen";
      this.btnDelete.UseVisualStyleBackColor = true;
      this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
      // 
      // btnRead
      // 
      this.btnRead.Location = new System.Drawing.Point(614, 30);
      this.btnRead.Name = "btnRead";
      this.btnRead.Size = new System.Drawing.Size(127, 44);
      this.btnRead.TabIndex = 4;
      this.btnRead.Text = "Lesen";
      this.btnRead.UseVisualStyleBackColor = true;
      this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
      // 
      // dataGridViewStudents
      // 
      this.dataGridViewStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridViewStudents.Location = new System.Drawing.Point(48, 98);
      this.dataGridViewStudents.Name = "dataGridViewStudents";
      this.dataGridViewStudents.RowHeadersWidth = 72;
      this.dataGridViewStudents.RowTemplate.Height = 31;
      this.dataGridViewStudents.Size = new System.Drawing.Size(693, 311);
      this.dataGridViewStudents.TabIndex = 5;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.dataGridViewStudents);
      this.Controls.Add(this.btnRead);
      this.Controls.Add(this.btnDelete);
      this.Controls.Add(this.btnUpdate);
      this.Controls.Add(this.btnAdd);
      this.Controls.Add(this.txtName);
      this.Name = "Form1";
      this.Text = "Erstes-CRUD";
      this.Load += new System.EventHandler(this.Form1_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

      }

    #endregion
    private System.Windows.Forms.TextBox txtName;
    private System.Windows.Forms.Button btnAdd;
    private System.Windows.Forms.Button btnUpdate;
    private System.Windows.Forms.Button btnDelete;
    private System.Windows.Forms.Button btnRead;
    private System.Windows.Forms.DataGridView dataGridViewStudents;
    }
  }

