using System;
using System.Collections.Generic;
using Debug = AssignmentSystem.Services.AssignmentDebugConsole;

namespace Assignment
{
    public class StudentWebBrowser : IWebBrowser
    {
        private Stack<string> backStack = new Stack<string>();
        private Stack<string> forwardStack = new Stack<string>();

        public void Open(string url)
        {
            // AS02: Your code here ...
            throw new NotImplementedException();
        }

        public void Back()
        {
            // AS02: Your code here ...
            throw new NotImplementedException();
        }

        public void Forward()
        {
            // AS02: Your code here ...
            throw new NotImplementedException();
        }

        public string Current()
        {
            // AS02: Your code here ...
            throw new NotImplementedException();
        }
    }

    public class StudentSolution : IAssignment
    {
        #region Midterm Exam

        public void AS01_CountVowels(LinkedList<string> alphabets)
        {
            // AS01: Your code here ...
            throw new NotImplementedException();
        }

        public void AS02_WebBrowserNavigation(string actions)
        {
            StudentWebBrowser webBrowser = new StudentWebBrowser();
            if (webBrowser == null || string.IsNullOrEmpty(actions))
            {
                return;
            }
            string[] actionList = actions.Split(';');
            foreach (string action in actionList)
            {
                if (action.Trim().StartsWith("open "))
                {
                    string url = action.Substring(5).Trim();
                    webBrowser.Open(url);
                }
                else if (action.Trim().ToLower() == "back")
                {
                    webBrowser.Back();
                }
                else if (action.Trim().ToLower() == "forward")
                {
                    webBrowser.Forward();
                }
                else if (action.Trim().ToLower() == "current")
                {
                    Debug.Log(webBrowser.Current());
                }
            }
        }

        public int AS03_CountTotalNode(Node root)
        {
            // AS03: Your code here ...
            throw new NotImplementedException();
        }

        #endregion
    }
}