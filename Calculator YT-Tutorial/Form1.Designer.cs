namespace Calculator
  {
  partial class Form1
    {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
      {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager( typeof( Form1 ) );
      buttonOne = new Button();
      button1 = new Button();
      button2 = new Button();
      button3 = new Button();
      button4 = new Button();
      button5 = new Button();
      button6 = new Button();
      button7 = new Button();
      button8 = new Button();
      button9 = new Button();
      button11 = new Button();
      button12 = new Button();
      button13 = new Button();
      button14 = new Button();
      button15 = new Button();
      button16 = new Button();
      button17 = new Button();
      button19 = new Button();
      textBox_Result = new TextBox();
      labelCurrentOperation = new Label();
      SuspendLayout();
      // 
      // buttonOne
      // 
      buttonOne.Font = new Font( "Segoe UI", 14F );
      buttonOne.Location = new Point( 12, 84 );
      buttonOne.Name = "buttonOne";
      buttonOne.Size = new Size( 45, 45 );
      buttonOne.TabIndex = 0;
      buttonOne.Text = "7";
      buttonOne.UseVisualStyleBackColor = true;
      buttonOne.Click +=  button_click ;
      // 
      // button1
      // 
      button1.Font = new Font( "Segoe UI", 14F );
      button1.Location = new Point( 63, 84 );
      button1.Name = "button1";
      button1.Size = new Size( 45, 45 );
      button1.TabIndex = 1;
      button1.Text = "8";
      button1.UseVisualStyleBackColor = true;
      button1.Click +=  button_click ;
      // 
      // button2
      // 
      button2.Font = new Font( "Segoe UI", 14F );
      button2.Location = new Point( 114, 84 );
      button2.Name = "button2";
      button2.Size = new Size( 45, 45 );
      button2.TabIndex = 2;
      button2.Text = "9";
      button2.UseVisualStyleBackColor = true;
      button2.Click +=  button_click ;
      // 
      // button3
      // 
      button3.Font = new Font( "Segoe UI", 14F );
      button3.Location = new Point( 165, 84 );
      button3.Name = "button3";
      button3.Size = new Size( 45, 45 );
      button3.TabIndex = 3;
      button3.Text = "/";
      button3.UseVisualStyleBackColor = true;
      button3.Click +=  operator_click ;
      // 
      // button4
      // 
      button4.Font = new Font( "Segoe UI", 14F );
      button4.Location = new Point( 216, 84 );
      button4.Name = "button4";
      button4.Size = new Size( 45, 45 );
      button4.TabIndex = 4;
      button4.Text = "CE";
      button4.UseVisualStyleBackColor = true;
      button4.Click +=  button4_Click ;
      // 
      // button5
      // 
      button5.Font = new Font( "Segoe UI", 14F );
      button5.Location = new Point( 216, 135 );
      button5.Name = "button5";
      button5.Size = new Size( 45, 45 );
      button5.TabIndex = 9;
      button5.Text = "C";
      button5.UseVisualStyleBackColor = true;
      button5.Click +=  button5_Click ;
      // 
      // button6
      // 
      button6.Font = new Font( "Segoe UI", 14F );
      button6.Location = new Point( 165, 135 );
      button6.Name = "button6";
      button6.Size = new Size( 45, 45 );
      button6.TabIndex = 8;
      button6.Text = "*";
      button6.UseVisualStyleBackColor = true;
      button6.Click +=  operator_click ;
      // 
      // button7
      // 
      button7.Font = new Font( "Segoe UI", 14F );
      button7.Location = new Point( 114, 135 );
      button7.Name = "button7";
      button7.Size = new Size( 45, 45 );
      button7.TabIndex = 7;
      button7.Text = "6";
      button7.UseVisualStyleBackColor = true;
      button7.Click +=  button_click ;
      // 
      // button8
      // 
      button8.Font = new Font( "Segoe UI", 14F );
      button8.Location = new Point( 63, 135 );
      button8.Name = "button8";
      button8.Size = new Size( 45, 45 );
      button8.TabIndex = 6;
      button8.Text = "5";
      button8.UseVisualStyleBackColor = true;
      button8.Click +=  button_click ;
      // 
      // button9
      // 
      button9.Font = new Font( "Segoe UI", 14F );
      button9.Location = new Point( 12, 135 );
      button9.Name = "button9";
      button9.Size = new Size( 45, 45 );
      button9.TabIndex = 5;
      button9.Text = "4";
      button9.UseVisualStyleBackColor = true;
      button9.Click +=  button_click ;
      // 
      // button11
      // 
      button11.Font = new Font( "Segoe UI", 14F );
      button11.Location = new Point( 165, 186 );
      button11.Name = "button11";
      button11.Size = new Size( 45, 45 );
      button11.TabIndex = 13;
      button11.Text = "-";
      button11.UseVisualStyleBackColor = true;
      button11.Click +=  operator_click ;
      // 
      // button12
      // 
      button12.Font = new Font( "Segoe UI", 14F );
      button12.Location = new Point( 114, 186 );
      button12.Name = "button12";
      button12.Size = new Size( 45, 45 );
      button12.TabIndex = 12;
      button12.Text = "3";
      button12.UseVisualStyleBackColor = true;
      button12.Click +=  button_click ;
      // 
      // button13
      // 
      button13.Font = new Font( "Segoe UI", 14F );
      button13.Location = new Point( 63, 186 );
      button13.Name = "button13";
      button13.Size = new Size( 45, 45 );
      button13.TabIndex = 11;
      button13.Text = "2";
      button13.UseVisualStyleBackColor = true;
      button13.Click +=  button_click ;
      // 
      // button14
      // 
      button14.Font = new Font( "Segoe UI", 14F );
      button14.Location = new Point( 12, 186 );
      button14.Name = "button14";
      button14.Size = new Size( 45, 45 );
      button14.TabIndex = 10;
      button14.Text = "1";
      button14.UseVisualStyleBackColor = true;
      button14.Click +=  button_click ;
      // 
      // button15
      // 
      button15.Font = new Font( "Segoe UI", 14F );
      button15.Location = new Point( 216, 186 );
      button15.Name = "button15";
      button15.Size = new Size( 45, 96 );
      button15.TabIndex = 19;
      button15.Text = "=";
      button15.UseVisualStyleBackColor = true;
      button15.Click +=  button15_Click ;
      // 
      // button16
      // 
      button16.Font = new Font( "Segoe UI", 14F );
      button16.Location = new Point( 165, 237 );
      button16.Name = "button16";
      button16.Size = new Size( 45, 45 );
      button16.TabIndex = 18;
      button16.Text = "+";
      button16.UseVisualStyleBackColor = true;
      button16.Click +=  operator_click ;
      // 
      // button17
      // 
      button17.Font = new Font( "Segoe UI", 14F );
      button17.Location = new Point( 114, 237 );
      button17.Name = "button17";
      button17.Size = new Size( 45, 45 );
      button17.TabIndex = 17;
      button17.Text = ".";
      button17.UseVisualStyleBackColor = true;
      button17.Click +=  button_click ;
      // 
      // button19
      // 
      button19.Font = new Font( "Segoe UI", 14F );
      button19.Location = new Point( 12, 237 );
      button19.Name = "button19";
      button19.Size = new Size( 96, 45 );
      button19.TabIndex = 15;
      button19.Text = "0";
      button19.UseVisualStyleBackColor = true;
      button19.Click +=  button_click ;
      // 
      // textBox_Result
      // 
      textBox_Result.Location = new Point( 12, 55 );
      textBox_Result.Name = "textBox_Result";
      textBox_Result.Size = new Size( 249, 23 );
      textBox_Result.TabIndex = 20;
      textBox_Result.Text = "0";
      textBox_Result.TextAlign = HorizontalAlignment.Right;
      // 
      // labelCurrentOperation
      // 
      labelCurrentOperation.AutoSize = true;
      labelCurrentOperation.BackColor = SystemColors.Window;
      labelCurrentOperation.Font = new Font( "Segoe UI", 14F );
      labelCurrentOperation.ForeColor = SystemColors.ControlDark;
      labelCurrentOperation.Location = new Point( 12, 27 );
      labelCurrentOperation.Name = "labelCurrentOperation";
      labelCurrentOperation.Size = new Size( 0, 25 );
      labelCurrentOperation.TabIndex = 21;
      // 
      // Form1
      // 
      AutoScaleDimensions = new SizeF( 7F, 15F );
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size( 275, 294 );
      Controls.Add( labelCurrentOperation );
      Controls.Add( textBox_Result );
      Controls.Add( button15 );
      Controls.Add( button16 );
      Controls.Add( button17 );
      Controls.Add( button19 );
      Controls.Add( button11 );
      Controls.Add( button12 );
      Controls.Add( button13 );
      Controls.Add( button14 );
      Controls.Add( button5 );
      Controls.Add( button6 );
      Controls.Add( button7 );
      Controls.Add( button8 );
      Controls.Add( button9 );
      Controls.Add( button4 );
      Controls.Add( button3 );
      Controls.Add( button2 );
      Controls.Add( button1 );
      Controls.Add( buttonOne );
      FormBorderStyle = FormBorderStyle.FixedDialog;
      Icon = (Icon) resources.GetObject( "$this.Icon" );
      MaximizeBox = false;
      Name = "Form1";
      StartPosition = FormStartPosition.CenterScreen;
      Text = "Calculator";
      Load +=  Form1_Load ;
      ResumeLayout( false );
      PerformLayout();
      }

    #endregion

    private Button buttonOne;
    private Button button1;
    private Button button2;
    private Button button3;
    private Button button4;
    private Button button5;
    private Button button6;
    private Button button7;
    private Button button8;
    private Button button9;
    private Button button11;
    private Button button12;
    private Button button13;
    private Button button14;
    private Button button15;
    private Button button16;
    private Button button17;
    private Button button19;
    private TextBox textBox_Result;
    private Label labelCurrentOperation;
    }
  }
