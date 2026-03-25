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
           if (string.IsNullOrEmpty(url))
            {
                return;
            }

            if (backStack.Count > 0)
            {
                backStack.Push(backStack.Peek());
            }

            backStack.Push(url);
            forwardStack.Clear();
        }

        public void Back()
        {
             if (backStack.Count <= 1)
            {
                return;
            }

            forwardStack.Push(backStack.Pop());
        }

        public void Forward()
        {
             if (forwardStack.Count == 0)
            {
                return;
            }

            backStack.Push(forwardStack.Pop());
        }

        public string Current()
        {
            if (backStack.Count == 0)
            {
                return "";
            }

            return backStack.Peek();
        }
    }

    public class StudentSolution : IAssignment
    {
        #region Midterm Exam

        public void AS01_CountVowels(LinkedList<string> alphabets)
        {
            int count = 0;
            if (alphabets != null)
            {
                foreach (string alphabet in alphabets)
                {
                    if (alphabet == "a"||alphabet == "e"||alphabet == "i"||alphabet == "o" || alphabet == "u")
                    {
                        count++;
                    }
                }
            }
            Debug.Log(count);
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
             {
            if (root == null)
            {
             return 0;
            }

            return 1 + AS03_CountTotalNode(root.left) + AS03_CountTotalNode(root.right);
        }
        }

        #endregion
    }
}