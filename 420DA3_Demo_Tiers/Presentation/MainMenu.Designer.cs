namespace _420DA3_Demo_Tiers.Presentation;

partial class MainMenu {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
        if (disposing && (components != null)) {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
        this.bottomPanel = new Panel();
        this.leftPanel = new Panel();
        this.rightPanel = new Panel();
        this.centerPanel = new Panel();
        this.manageStudentsButton = new Button();
        this.manageTeachersButton = new Button();
        this.manageCoursesButton = new Button();
        this.manageClassGroupsButton = new Button();
        this.quitButton = new Button();
        this.bottomPanel.SuspendLayout();
        this.centerPanel.SuspendLayout();
        this.SuspendLayout();
        // 
        // bottomPanel
        // 
        this.bottomPanel.Controls.Add(this.quitButton);
        this.bottomPanel.Dock = DockStyle.Bottom;
        this.bottomPanel.Location = new Point(0, 361);
        this.bottomPanel.Name = "bottomPanel";
        this.bottomPanel.Size = new Size(384, 100);
        this.bottomPanel.TabIndex = 0;
        // 
        // leftPanel
        // 
        this.leftPanel.Dock = DockStyle.Left;
        this.leftPanel.Location = new Point(0, 0);
        this.leftPanel.Name = "leftPanel";
        this.leftPanel.Size = new Size(100, 361);
        this.leftPanel.TabIndex = 1;
        // 
        // rightPanel
        // 
        this.rightPanel.Dock = DockStyle.Right;
        this.rightPanel.Location = new Point(284, 0);
        this.rightPanel.Name = "rightPanel";
        this.rightPanel.Size = new Size(100, 361);
        this.rightPanel.TabIndex = 2;
        // 
        // centerPanel
        // 
        this.centerPanel.Controls.Add(this.manageClassGroupsButton);
        this.centerPanel.Controls.Add(this.manageCoursesButton);
        this.centerPanel.Controls.Add(this.manageTeachersButton);
        this.centerPanel.Controls.Add(this.manageStudentsButton);
        this.centerPanel.Dock = DockStyle.Fill;
        this.centerPanel.Location = new Point(100, 0);
        this.centerPanel.Name = "centerPanel";
        this.centerPanel.Size = new Size(184, 361);
        this.centerPanel.TabIndex = 3;
        // 
        // manageStudentsButton
        // 
        this.manageStudentsButton.Location = new Point(6, 73);
        this.manageStudentsButton.Name = "manageStudentsButton";
        this.manageStudentsButton.Size = new Size(172, 40);
        this.manageStudentsButton.TabIndex = 0;
        this.manageStudentsButton.Text = "Manage Students";
        this.manageStudentsButton.UseVisualStyleBackColor = true;
        // 
        // manageTeachersButton
        // 
        this.manageTeachersButton.Location = new Point(6, 119);
        this.manageTeachersButton.Name = "manageTeachersButton";
        this.manageTeachersButton.Size = new Size(172, 40);
        this.manageTeachersButton.TabIndex = 1;
        this.manageTeachersButton.Text = "Manage Teachers";
        this.manageTeachersButton.UseVisualStyleBackColor = true;
        // 
        // manageCoursesButton
        // 
        this.manageCoursesButton.Location = new Point(6, 165);
        this.manageCoursesButton.Name = "manageCoursesButton";
        this.manageCoursesButton.Size = new Size(172, 40);
        this.manageCoursesButton.TabIndex = 2;
        this.manageCoursesButton.Text = "Manage Courses";
        this.manageCoursesButton.UseVisualStyleBackColor = true;
        // 
        // manageClassGroupsButton
        // 
        this.manageClassGroupsButton.Location = new Point(6, 211);
        this.manageClassGroupsButton.Name = "manageClassGroupsButton";
        this.manageClassGroupsButton.Size = new Size(172, 40);
        this.manageClassGroupsButton.TabIndex = 3;
        this.manageClassGroupsButton.Text = "Manage Class Groups";
        this.manageClassGroupsButton.UseVisualStyleBackColor = true;
        // 
        // quitButton
        // 
        this.quitButton.Location = new Point(106, 6);
        this.quitButton.Name = "quitButton";
        this.quitButton.Size = new Size(172, 40);
        this.quitButton.TabIndex = 3;
        this.quitButton.Text = "Quit";
        this.quitButton.UseVisualStyleBackColor = true;
        // 
        // MainMenu
        // 
        this.AutoScaleDimensions = new SizeF(7F, 15F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(384, 461);
        this.Controls.Add(this.centerPanel);
        this.Controls.Add(this.rightPanel);
        this.Controls.Add(this.leftPanel);
        this.Controls.Add(this.bottomPanel);
        this.Name = "MainMenu";
        this.StartPosition = FormStartPosition.CenterScreen;
        this.Text = "Menu Principal";
        this.bottomPanel.ResumeLayout(false);
        this.centerPanel.ResumeLayout(false);
        this.ResumeLayout(false);
    }

    #endregion

    private Panel bottomPanel;
    private Panel leftPanel;
    private Panel rightPanel;
    private Panel centerPanel;
    private Button manageCoursesButton;
    private Button manageTeachersButton;
    private Button manageStudentsButton;
    private Button quitButton;
    private Button manageClassGroupsButton;
}