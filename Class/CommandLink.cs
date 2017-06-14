using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

public class CommandLink : Button
{
    const int BS_COMMANDLINK = 0x0000000E;

    //Set button's flatstyle to system
    public CommandLink()
    {
        this.FlatStyle = FlatStyle.System;
    }

    protected override CreateParams CreateParams
    {
        get
        {
            CreateParams cParams = base.CreateParams;
            //Set the button to use Commandlink styles
            cParams.Style |= BS_COMMANDLINK;
            return cParams;
        }
    }
    const uint BCM_SETNOTE = 0x00001609;
    //Imports the user32.dll
    [DllImport("user32.dll", CharSet = CharSet.Unicode)]
    static extern IntPtr SendMessage
            (HandleRef hWnd, UInt32 Msg, IntPtr wParam, string lParam);
    //Note property
    private string note_ = "Example Note";
    public string Note
    {
        get
        {
            return this.note_;
        }
        set
        {
            this.note_ = value;
            this.SetNote(this.note_);
        }
    }

    //Sets the button's note
    void SetNote(string NoteText)
    {
        //Sets the note
        SendMessage(new HandleRef(this, this.Handle),
                    BCM_SETNOTE, IntPtr.Zero, NoteText);
    }
}