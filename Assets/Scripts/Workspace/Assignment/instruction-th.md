# Assignment 10: Midterm Exam - Linked Lists, Stack & Binary Trees

## 🎯 จุดประสงค์การเรียนรู้

- ทดสอบการใช้งาน Linked List พื้นฐาน
- หลักการทำงานของ Stack ในการจัดการข้อมูล LIFO
- โครงสร้าง Binary Tree และการสำรวจต้นไม้
- ประยุกต์ใช้ Linked Lists, Stack, และ Binary Trees ในการแก้ปัญหา
- เขียนโปรแกรมที่มีประสิทธิภาพในการจัดการโครงสร้างข้อมูลต่างๆ

## 📚 โครงสร้างของ Assignment

- **Assignment Methods (3 methods)** - ข้อสอบสำหรับวัดความเข้าใจเกี่ยวกับ Linked Lists, Stack, และ Binary Trees

---

## 🧠 ความรู้พื้นฐานที่ควรทราบ

### Linked List คืออะไร?
Linked List คือโครงสร้างข้อมูลแบบเชิงเส้นที่ประกอบด้วย nodes ที่เชื่อมต่อกันด้วย references โดยแต่ละ node มี data และ link ไปยัง node ถัดไป

### Stack คืออะไร?
Stack คือโครงสร้างข้อมูลแบบ LIFO (Last In First Out) ข้อมูลที่เพิ่มเข้าไปล่าสุดจะถูกนำออกมาก่อน

### Binary Tree คืออะไร?
Binary Tree คือโครงสร้างข้อมูลแบบต้นไม้ที่แต่ละ node มีลูก (child) ได้สูงสุด 2 ตัว (left และ right)

### Operations พื้นฐาน
- **Linked List**: Add, Remove, Traverse, Count
- **Stack**: Push (เพิ่ม), Pop (ลบบนสุด), Peek (ดูบนสุด), Count (จำนวน)
- **Binary Tree**: Insert, Delete, Traverse (Pre-order, In-order, Post-order), Count nodes

---

## Assignment Methods

### AS01_CountVowels

**วัตถุประสงค์:** นับจำนวนสระในตัวอักษรเล็ก (a, e, i, o, u) โดยใช้ Linked List

**คำอธิบายปัญหา:**
เขียนโปรแกรมที่รับ LinkedList<string> ที่ประกอบด้วยตัวอักษรเล็ก และนับจำนวนสระที่ปรากฏในลิสต์นั้น

ในเกมสามารถใช้ในการ:
- จำนวนของ power-ups ประเภทสระที่อยู่ในสต็อก
- นับ vowel letters ในคำศัพท์เกม
- วิเคราะห์ composition ของ items ใน inventory

**Method Signature:**
```csharp
public void AS01_CountVowels(LinkedList<string> alphabets)
```

**Logic ที่ต้อง implement:**
1. รับ LinkedList<string> ที่เต็มไปด้วยตัวอักษรเล็ก
2. วนลูปผ่านแต่ละสมาชิกในลิสต์
3. ตรวจสอบว่าเป็นสระ (a, e, i, o, u) หรือไม่
4. นับจำนวนสระทั้งหมด
5. แสดงผลลัพธ์เป็นตัวเลข

**Test Cases:**

1. **Input:** alphabets = []
   **Expected Output:**
   ```
   0
   ```

2. **Input:** alphabets = ["a"]
   **Expected Output:**
   ```
   1
   ```

3. **Input:** alphabets = ["a", "e", "i", "o", "u"]
   **Expected Output:**
   ```
   5
   ```

4. **Input:** alphabets = ["a", "b", "e", "c", "i", "d", "o", "u"]
   **Expected Output:**
   ```
   5
   ```

5. **Input:** alphabets = ["b", "c", "d", "f"]
   **Expected Output:**
   ```
   0
   ```

6. **Input:** alphabets = ["a", "a", "a", "e", "e"]
   **Expected Output:**
   ```
   5
   ```

---

### AS02_WebBrowserNavigation

**วัตถุประสงค์:** จำลองระบบนำทางของเบราว์เซอร์โดยใช้ Stack

**คำอธิบายปัญหา:**
เขียนโปรแกรมที่จำลองการทำงานของเบราว์เซอร์ web โดยรองรับคำสั่งดังต่อไปนี้:
- `open <url>` - เปิด URL ใหม่
- `back` - ย้อนกลับไปยังหน้าก่อนหน้า
- `forward` - ไปยังหน้าถัดไป
- `current` - แสดง URL ปัจจุบัน

ในเกมสามารถใช้ในการ:
- ระบบ UI navigation ที่มี back/forward functionality
- Game menu navigation system
- Dialog/screen history management

**Method Signature:**
```csharp
public void AS02_WebBrowserNavigation(string actions)
```

**Logic ที่ต้อง implement:**
1. เขียน code ใน function ต่างๆของ StudentWebBrowser ใช้ 2 Stacks เพื่อเก็บ back history และ forward history
2. ใน AS02_WebBrowserNavigation ได้มี code ที่ทำการ parse คำสั่งต่างๆ และเรียกใช้ method ที่เหมาะสม
3. สำหรับแต่ละคำสั่ง:
   - `open <url>` - เรียก Open(url) เพื่อเปิด URL ใหม่
   - `back` - เรียก Back() เพื่อกลับไปหน้าก่อน
   - `forward` - เรียก Forward() เพื่อไปหน้าถัดไป
   - `current` - เรียก Current() เพื่อแสดง URL ปัจจุบัน

**Test Cases:**

1. **Input:** actions = "open google.com; current"
   **Expected Output:**
   ```
   google.com
   ```

2. **Input:** actions = "open google.com; open youtube.com; back; current"
   **Expected Output:**
   ```
   google.com
   ```

3. **Input:** actions = "back; current"
   **Expected Output:**
   ```
   
   ```
   (empty string - no page opened)

4. **Input:** actions = "open google.com; open youtube.com; back; forward; current"
   **Expected Output:**
   ```
   youtube.com
   ```

5. **Input:** actions = "open google.com; forward; current"
   **Expected Output:**
   ```
   google.com
   ```
   (forward ไม่มีผลเพราะไม่เคยกลับไป)

6. **Input:** actions = "open google.com; open youtube.com; open github.com; back; back; forward; current"
   **Expected Output:**
   ```
   youtube.com
   ```

---

### AS03_CountTotalNode

**วัตถุประสงค์:** นับจำนวนโหนดทั้งหมดใน Binary Tree โดยใช้ Recursion

**คำอธิบายปัญหา:**
เขียนโปรแกรมที่รับ Binary Tree และนับจำนวนโหนดทั้งหมดในต้นไม้นั้น

ในเกมสามารถใช้ในการ:
- นับจำนวน game objects ในแต่ละ tree structure
- วิเคราะห์ complexity ของ game scene hierarchy
- จัดการ skill tree nodes ในการคำนวณ unlocked skills
- นับ dialogue tree nodes สำหรับ NPC conversations

**Method Signature:**
```csharp
public int AS03_CountTotalNode(Node root)
```

**Logic ที่ต้อง implement:**
1. ใช้ Recursion (recursive method)
2. Base case: ถ้า root เป็น null ให้ return 0
3. Recursive case: return 1 + count of left subtree + count of right subtree
4. Return ผลรวมจำนวนโหนดทั้งหมด

**Test Cases:**

1. **Input:** root = null
   **Expected Output:**
   ```
   0
   ```

2. **Input:** root = Node(1)
   **Expected Output:**
   ```
   1
   ```

3. **Input:** root = Node(1), root.left = Node(2)
   **Expected Output:**
   ```
   2
   ```

4. **Input:** root = Node(1), root.left = Node(2), root.right = Node(3)
   **Expected Output:**
   ```
   3
   ```

5. **Input:** Complete Binary Tree:
   ```
        1
       / \
      2   3
     / \
    4   5
   ```
   **Expected Output:**
   ```
   5
   ```

6. **Input:** Left-skewed Tree:
   ```
   1
   |
   2
   |
   3
   |
   4
   ```
   **Expected Output:**
   ```
   4
   ```

7. **Input:** Right-skewed Tree:
   ```
   1
    \
     2
      \
       3
        \
         4
   ```
   **Expected Output:**
   ```
   4
   ```

8. **Input:** Complex Tree:
   ```
            1
          /   \
         2     3
        / \   / \
       4   5 6   7
      /
     8
   ```
   **Expected Output:**
   ```
   8
   ```

---

## 💡 Tips สำหรับการทำ Assignment

### AS01_CountVowels
- ใช้ HashSet เพื่อเก็บสระเพื่อให้การตรวจสอบเร็วขึ้น
- LinkedList มี foreach support ให้ใช้ foreach loop ได้โดยตรง
- สระมีแค่ 5 ตัว: a, e, i, o, u

### AS02_WebBrowserNavigation
- ใช้ 2 stacks: หนึ่งเก็บ back history อีกหนึ่งเก็บ forward history
- เมื่อเปิด URL ใหม่ ให้ Clear forward stack
- currentUrl ควรติดตาม URL ปัจจุบัน เริ่มต้นเป็น null

### AS03_CountTotalNode
- ใช้ Recursion ตามสูตร: 1 + left + right
- ตรวจสอบ null ให้ดี (Base case)
- Test กับ tree ที่มีรูปทรง (shape) ต่างๆ

---

## 📝 หมายเหตุสำคัญ

1. Assignment นี้เป็นข้อสอบปลายภาค ทดสอบความเข้าใจเรื่องต่างๆ ที่เรียนมา
2. ให้ใช้โครงสร้างข้อมูลที่ถูกต้องและ Algorithm ที่มีประสิทธิภาพ
3. ต้องจัดการ Edge cases เช่น empty list, null references อย่างถูกต้อง
4. ลองทำ test cases ทั้งหมดให้ผ่านก่อนส่งงาน
5. ระดับความยากจะเพิ่มขึ้นจากตัวอักษรประกาศ คำนวณให้แน่นอน
