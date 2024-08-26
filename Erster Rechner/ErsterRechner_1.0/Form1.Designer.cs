namespace ErsterRechner
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
      label_input = new Label();
      label_output = new Label();
      byte_input = new TextBox();
      byte_output = new TextBox();
      SuspendLayout();
      // 
      // label_input
      // 
      label_input.AutoSize = true;
      label_input.Font = new Font( "Segoe UI", 18F );
      label_input.Location = new Point( 34, 54 );
      label_input.Name = "label_input";
      label_input.Size = new Size( 369, 32 );
      label_input.TabIndex = 0;
      label_input.Text = "gebe eine Zahl von 0 bis 255 ein:";
      // 
      // label_output
      // 
      label_output.AutoSize = true;
      label_output.Font = new Font( "Segoe UI", 18F );
      label_output.Location = new Point( 34, 140 );
      label_output.Name = "label_output";
      label_output.Size = new Size( 497, 32 );
      label_output.TabIndex = 1;
      label_output.Text = "hier ist das Doppelte der eingegebenen Zahl:";
      // 
      // byte_input
      // 
      byte_input.Font = new Font( "Segoe UI", 15F );
      byte_input.Location = new Point( 553, 52 );
      byte_input.Name = "byte_input";
      byte_input.Size = new Size( 219, 34 );
      byte_input.TabIndex = 2;
      byte_input.TextChanged +=  textBox1_TextChanged ;
      // 
      // byte_output
      // 
      byte_output.Font = new Font( "Segoe UI", 15F );
      byte_output.Location = new Point( 553, 138 );
      byte_output.Name = "byte_output";
      byte_output.ReadOnly = true;
      byte_output.Size = new Size( 219, 34 );
      byte_output.TabIndex = 3;
      // 
      // Form1
      // 
      AutoScaleDimensions = new SizeF( 7F, 15F );
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size( 800, 450 );
      Controls.Add( byte_output );
      Controls.Add( byte_input );
      Controls.Add( label_output );
      Controls.Add( label_input );
      Name = "Form1";
      Text = "Form1";
      ResumeLayout( false );
      PerformLayout();
      }

    #endregion

    private Label label_input;
    private Label label_output;
    private TextBox byte_input;
    private TextBox byte_output;
    }
  }
