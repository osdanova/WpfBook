# [WPF Book](../readme.md)

## File Dialogs

File dialogs allow the user to select files.

[OpenFileDialog docs](https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.openfiledialog?view=windowsdesktop-8.0)

    using (OpenFileDialog openFileDialog = new OpenFileDialog())
    {
        // These are optional
        openFileDialog.InitialDirectory = "c:\\";
        openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
        openFileDialog.FilterIndex = 2;
        openFileDialog.RestoreDirectory = true;

        if (openFileDialog.ShowDialog() == DialogResult.OK)
        {
            // Do something with file at openFileDialog.FileName
        }
    }

[SaveFileDialog docs](https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.savefiledialog?view=windowsdesktop-8.0)

    SaveFileDialog saveFileDialog1 = new SaveFileDialog();
    // These are optional
    saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"  ;
    saveFileDialog1.FilterIndex = 2 ;
    saveFileDialog1.RestoreDirectory = true ;

    if(saveFileDialog1.ShowDialog() == DialogResult.OK)
    {
        // Do something with file at saveFileDialog1.FileName
    }
    