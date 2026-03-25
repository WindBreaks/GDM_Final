using System;
using System.Collections.Generic;
using AssignmentSystem.Services;
using NUnit.Framework;
using UnityEngine;

namespace Assignment
{
    public class Assignment_Testcase
    {
        private IAssignment assignment;

        [SetUp]
        public void Setup()
        {
            // Reset static state before each test
            AssignmentDebugConsole.Clear();

            // Use StudentSolution as the test subject
            assignment = new StudentSolution();
        }

        [TearDown]
        public void Teardown()
        {
            if (assignment is MonoBehaviour)
            {
                MonoBehaviour.DestroyImmediate(assignment as MonoBehaviour);
            }
        }

        #region Midterm Exam

        [Category("Midterm")]
        [Test]
        public void Test_AS01_CountVowels_EmptyList()
        {
            LinkedList<string> alphabets = new LinkedList<string>();
            assignment.AS01_CountVowels(alphabets);
            string expected = "0";
            string actual = AssignmentDebugConsole.GetOutput().Trim();
            TestUtils.AssertMultilineEqual(expected, actual);
        }

        [Category("Midterm")]
        [Test]
        public void Test_AS01_CountVowels_SingleVowel()
        {
            LinkedList<string> alphabets = new LinkedList<string>();
            alphabets.AddLast("a");
            assignment.AS01_CountVowels(alphabets);
            string expected = "1";
            string actual = AssignmentDebugConsole.GetOutput().Trim();
            TestUtils.AssertMultilineEqual(expected, actual);
        }

        [Category("Midterm")]
        [Test]
        public void Test_AS01_CountVowels_AllVowels()
        {
            LinkedList<string> alphabets = new LinkedList<string>();
            alphabets.AddLast("a");
            alphabets.AddLast("e");
            alphabets.AddLast("i");
            alphabets.AddLast("o");
            alphabets.AddLast("u");
            assignment.AS01_CountVowels(alphabets);
            string expected = "5";
            string actual = AssignmentDebugConsole.GetOutput().Trim();
            TestUtils.AssertMultilineEqual(expected, actual);
        }

        [Category("Midterm")]
        [Test]
        public void Test_AS01_CountVowels_MixedWithConsonants()
        {
            LinkedList<string> alphabets = new LinkedList<string>();
            alphabets.AddLast("a");
            alphabets.AddLast("b");
            alphabets.AddLast("e");
            alphabets.AddLast("c");
            alphabets.AddLast("i");
            alphabets.AddLast("d");
            alphabets.AddLast("o");
            alphabets.AddLast("u");
            assignment.AS01_CountVowels(alphabets);
            string expected = "5";
            string actual = AssignmentDebugConsole.GetOutput().Trim();
            TestUtils.AssertMultilineEqual(expected, actual);
        }

        [Category("Midterm")]
        [Test]
        public void Test_AS01_CountVowels_NoVowels()
        {
            LinkedList<string> alphabets = new LinkedList<string>();
            alphabets.AddLast("b");
            alphabets.AddLast("c");
            alphabets.AddLast("d");
            alphabets.AddLast("f");
            assignment.AS01_CountVowels(alphabets);
            string expected = "0";
            string actual = AssignmentDebugConsole.GetOutput().Trim();
            TestUtils.AssertMultilineEqual(expected, actual);
        }

        [Category("Midterm")]
        [Test]
        public void Test_AS01_CountVowels_DuplicateVowels()
        {
            LinkedList<string> alphabets = new LinkedList<string>();
            alphabets.AddLast("a");
            alphabets.AddLast("a");
            alphabets.AddLast("a");
            alphabets.AddLast("e");
            alphabets.AddLast("e");
            assignment.AS01_CountVowels(alphabets);
            string expected = "5";
            string actual = AssignmentDebugConsole.GetOutput().Trim();
            TestUtils.AssertMultilineEqual(expected, actual);
        }

        [Category("Midterm")]
        [Test]
        public void Test_AS02_WebBrowserNavigation_OpenSingleUrl()
        {
            assignment.AS02_WebBrowserNavigation("open google.com; current");
            string expected = "google.com";
            string actual = AssignmentDebugConsole.GetOutput().Trim();
            TestUtils.AssertMultilineEqual(expected, actual);
        }

        [Category("Midterm")]
        [Test]
        public void Test_AS02_WebBrowserNavigation_OpenAndCurrent()
        {
            assignment.AS02_WebBrowserNavigation("open google.com; current");
            string expected = "google.com";
            string actual = AssignmentDebugConsole.GetOutput().Trim();
            TestUtils.AssertMultilineEqual(expected, actual);
        }

        [Category("Midterm")]
        [Test]
        public void Test_AS02_WebBrowserNavigation_OpenMultipleAndBack()
        {
            assignment.AS02_WebBrowserNavigation("open google.com; open youtube.com; back; current");
            string expected = "google.com";
            string actual = AssignmentDebugConsole.GetOutput().Trim();
            TestUtils.AssertMultilineEqual(expected, actual);
        }

        [Category("Midterm")]
        [Test]
        public void Test_AS02_WebBrowserNavigation_BackFromStart()
        {
            assignment.AS02_WebBrowserNavigation("back; current");
            string expected = "";
            string actual = AssignmentDebugConsole.GetOutput().Trim();
            TestUtils.AssertMultilineEqual(expected, actual);
        }

        [Category("Midterm")]
        [Test]
        public void Test_AS02_WebBrowserNavigation_ForwardAfterBack()
        {
            assignment.AS02_WebBrowserNavigation("open google.com; open youtube.com; back; forward; current");
            string expected = "youtube.com";
            string actual = AssignmentDebugConsole.GetOutput().Trim();
            TestUtils.AssertMultilineEqual(expected, actual);
        }

        [Category("Midterm")]
        [Test]
        public void Test_AS02_WebBrowserNavigation_ForwardWithoutBack()
        {
            assignment.AS02_WebBrowserNavigation("open google.com; forward; current");
            string expected = "google.com";
            string actual = AssignmentDebugConsole.GetOutput().Trim();
            TestUtils.AssertMultilineEqual(expected, actual);
        }

        [Category("Midterm")]
        [Test]
        public void Test_AS02_WebBrowserNavigation_ComplexNavigation()
        {
            assignment.AS02_WebBrowserNavigation("open google.com; open youtube.com; open github.com; back; back; forward; current");
            string expected = "youtube.com";
            string actual = AssignmentDebugConsole.GetOutput().Trim();
            TestUtils.AssertMultilineEqual(expected, actual);
        }

        [Category("Midterm")]
        [Test]
        public void Test_AS03_CountTotalNode_NullRoot()
        {
            int result = assignment.AS03_CountTotalNode(null);
            Assert.AreEqual(0, result);
        }

        [Category("Midterm")]
        [Test]
        public void Test_AS03_CountTotalNode_SingleNode()
        {
            Node root = new Node(1);
            int result = assignment.AS03_CountTotalNode(root);
            Assert.AreEqual(1, result);
        }

        [Category("Midterm")]
        [Test]
        public void Test_AS03_CountTotalNode_TwoNodes()
        {
            Node root = new Node(1);
            root.left = new Node(2);
            int result = assignment.AS03_CountTotalNode(root);
            Assert.AreEqual(2, result);
        }

        [Category("Midterm")]
        [Test]
        public void Test_AS03_CountTotalNode_ThreeNodes()
        {
            Node root = new Node(1);
            root.left = new Node(2);
            root.right = new Node(3);
            int result = assignment.AS03_CountTotalNode(root);
            Assert.AreEqual(3, result);
        }

        [Category("Midterm")]
        [Test]
        public void Test_AS03_CountTotalNode_CompleteTree()
        {
            //        1
            //       / \
            //      2   3
            //     / \
            //    4   5
            Node root = new Node(1);
            root.left = new Node(2);
            root.right = new Node(3);
            root.left.left = new Node(4);
            root.left.right = new Node(5);
            int result = assignment.AS03_CountTotalNode(root);
            Assert.AreEqual(5, result);
        }

        [Category("Midterm")]
        [Test]
        public void Test_AS03_CountTotalNode_LeftSkewedTree()
        {
            // 1
            // |
            // 2
            // |
            // 3
            // |
            // 4
            Node root = new Node(1);
            root.left = new Node(2);
            root.left.left = new Node(3);
            root.left.left.left = new Node(4);
            int result = assignment.AS03_CountTotalNode(root);
            Assert.AreEqual(4, result);
        }

        [Category("Midterm")]
        [Test]
        public void Test_AS03_CountTotalNode_RightSkewedTree()
        {
            // 1
            //  \
            //   2
            //    \
            //     3
            //      \
            //       4
            Node root = new Node(1);
            root.right = new Node(2);
            root.right.right = new Node(3);
            root.right.right.right = new Node(4);
            int result = assignment.AS03_CountTotalNode(root);
            Assert.AreEqual(4, result);
        }

        [Category("Midterm")]
        [Test]
        public void Test_AS03_CountTotalNode_ComplexTree()
        {
            //           1
            //         /   \
            //        2     3
            //       / \   / \
            //      4   5 6   7
            //     /
            //    8
            Node root = new Node(1);
            root.left = new Node(2);
            root.right = new Node(3);
            root.left.left = new Node(4);
            root.left.right = new Node(5);
            root.right.left = new Node(6);
            root.right.right = new Node(7);
            root.left.left.left = new Node(8);
            int result = assignment.AS03_CountTotalNode(root);
            Assert.AreEqual(8, result);
        }

        #endregion
    }

    public class TestUtils
    {
        internal static void AssertMultilineEqual(string expected, string actual, string message = null)
        {
            string normExpected = expected.Replace("\r\n", "\n").Replace("\r", "\n").Trim();
            string normActual = actual.Replace("\r\n", "\n").Replace("\r", "\n").Trim();
            if (string.IsNullOrEmpty(message))
            {
                message = $"Expected output:\n{normExpected}\n----\nActual output:\n{normActual}";
            }
            Assert.AreEqual(normExpected, normActual, message);
        }
    }
}
