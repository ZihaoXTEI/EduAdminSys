# 教学管理系统

## 一、项目实现功能

**设计任务**：教学管理是所有学校都应有的最基本的管理功能。教学管理系统实现学校的简单教学管理，包括学生入学登记、学生选课、教师登记考试成绩、补考处理、学生成绩统计、教师教学工作量统计，可随时查询出院系、教师、学生、课程、选课、成绩等情况。

**设计要求**：

1. 学生入学时，管理员要进行新生登记，登记后即可选课学习课程；
2. 每门课程可以同时开设多个班，由多位教师讲授，每位教师也可上多门课；
3. 每个学生最多可以选修120个学分(不考虑每学期的学分限制)，每门课有多个学生选修，满15人才开课，但不能超过50人，以保证教学质量。
4. 学生选修每门课会获得一个成绩，若成绩不及格则补考后还需记录补考成绩。只有成绩及格才能获得相应课程的学分。

## 二、数据库应用的硬件、软件环境介绍

**系统环境**：Microsoft Windows 10

**数据库软件**：Microsoft SQL Server 2017

**编程软件**：Microsoft Visual Studio 2017

**编程语言**：C#

## 三、概念结构设计

### 3.1 概念结构设计工具（E-R模型）

教务管理系统主要功能包括对院系信息、学生信息、教师信息、课程信息、班级信息、成绩信息管理，以及教师的登记成绩、教师学生选择班级的功能。主要功能如图：

![image-20220624155218759](https://github.com/ZihaoXTEI/EduAdminSys/tree/master/images/image-20220624155218759.png)

### 3.2 教师选择任课班级子系统

**功能描述**：

1. 处理教师选择任课的班级
2. 教师只能选择自己院系的课程班级
3. 教师可以选择任教多门课

**分E-R图**：

![image-20220624155330568](https://github.com/ZihaoXTEI/EduAdminSys/tree/master/images/image-20220624155330568.png)

### 3.3 学生选课子系统

**功能描述**：

1. 处理学生选修课程的班级。
2. 每个学生只能选择不同课程的其中一个班级，且选修的总学分不超过120分。

**分E-R图**：

![image-20220624155427250](https://github.com/ZihaoXTEI/EduAdminSys/tree/master/images/image-20220624155427250.png)

### 3.4 管理员管理子系统

**功能描述**：

1. 可以查询各类信息，如学生信息、教师信息、班级信息、成绩信息等。
2. 对相应的信息进行增加、删除和更改的操作。
3. 统计学生信息、教师信息、成绩信息的操作。

**分E-R图**：

![image-20220624155512524](https://github.com/ZihaoXTEI/EduAdminSys/tree/master/images/image-20220624155512524.png)

### 3.5 总体E-R图

每名教师可以任教多门自己所在院系的班级，学生可以选择不同课程的班级。管理员可以对所有信息进行管理。

![image-20220624155536654](https://github.com/ZihaoXTEI/EduAdminSys/tree/master/images/image-20220624155536654.png)

## 四、项目效果

### 4.1 软件启动界面

![image-20220624155945064](https://github.com/ZihaoXTEI/EduAdminSys/tree/master/images/image-20220624155945064.png)

### 4.1 数据查询操作

![image-20220624155644017](https://github.com/ZihaoXTEI/EduAdminSys/tree/master/images/image-20220624155644017.png)

![image-20220624155654789](https://github.com/ZihaoXTEI/EduAdminSys/tree/master/images/image-20220624155654789.png)

![image-20220624155900000](https://github.com/ZihaoXTEI/EduAdminSys/tree/master/images/image-20220624155900000.png)

![image-20220624155840853](https://github.com/ZihaoXTEI/EduAdminSys/tree/master/images/image-20220624155840853.png)



### 4.2 数据更新操作

![image-20220624155715202](https://github.com/ZihaoXTEI/EduAdminSys/tree/master/images/image-20220624155715202.png)

### 4. 数据删除操作

![image-20220624155744811](https://github.com/ZihaoXTEI/EduAdminSys/tree/master/images/image-20220624155744811.png)

![image-20220624155751999](https://github.com/ZihaoXTEI/EduAdminSys/tree/master/images/image-20220624155751999.png)

## 五、参考文献

[1]C#程序设计及应用教程（第2版）主编：马骏

[2]C#程序设计案例教程 主编：向燕飞

[3]C#项目开发全程实录（第4版）编著：明日科技

[4]数据库系统概论（第5版）主编：王珊、萨师煊

[5]Visual Studio 2015(C#)Windows数据库项目开发 主编：曾建华
