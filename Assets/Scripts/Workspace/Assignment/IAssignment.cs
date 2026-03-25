using System.Collections.Generic;
using UnityEngine;

namespace Assignment
{
    public interface IWebBrowser
    {
        void Open(string url);
        void Back();
        void Forward();
        string Current();
    }

    public class Node
    {
        public int val;
        public Node left;
        public Node right;

        public Node(int value)
        {
            val = value;
            left = right = null;
        }
    }

    public interface IAssignment
    {
        #region Midterm Exam

        /// <summary>
        /// เขียนโปรแกรมที่นับจำนวนสระ (a, e, i, o, u) ใน Linked List ของตัวอักษรเล็ก
        /// Instruction:
        /// เขียน logic ใน method CountVowels ซึ่งรับข้อมูล Linked List ที่มีตัวอักษรเล็กในแต่ละ node ซึ่งจะถูกส่งมาให้ในตัวแปร parameter ของ method CountVowelsLinkedList<string> list
        /// โดยให้มีการทำงานดังนี้
        /// นับจำนวนตัวอักษรที่เป็นสระ
        /// return ผลลัพธ์ควรเป็นจำนวนเต็มที่ระบุจำนวนสระใน Linked List
        /// </summary>
        /// <param name="alphabets"></param>
        public void AS01_CountVowels(LinkedList<string> alphabets);

        /// <summary>
        /// เขียนโปรแกรมที่จำลองระบบนำทางของเบราว์เซอร์ด้วยการใช้โครงสร้างข้อมูล Stack โดยทำงานดังนี้:
        /// คำสั่ง open <url>: เปิดหน้าเว็บใหม่และเพิ่มไปยังสแต็ค "Back"
        /// คำสั่ง back: ย้อนกลับไปยังหน้าก่อนหน้า ถ้ามี หากไม่มีให้แสดงผลว่า "ไม่สามารถย้อนกลับได้"
        /// คำสั่ง forward: ไปยังหน้าถัดไปที่เพิ่งเปิด (ถ้ามี) หากไม่มีให้แสดงผลว่า "ไม่สามารถไปข้างหน้าได้"
        /// คำสั่ง current: แสดงหน้าเว็บปัจจุบัน
        /// </summary>
        /// <param name="webBrowser"></param>
        /// <param name="actions"></param>
        public void AS02_WebBrowserNavigation(string actions);

        /// <summary>
        /// ให้เขียนฟังก์ชัน CountNodes เพื่อหาจำนวนโหนดทั้งหมดใน Binary Tree
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public int AS03_CountTotalNode(Node root);


        #endregion
    }
}
