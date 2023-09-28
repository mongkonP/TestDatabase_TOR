--ข้อมูลพนักงำน/tblEmp
CREATE TABLE tblEmp (
    Id_officer NUMERIC(10, 5) PRIMARY KEY,/* หมายเลขพนักงาน*/
    F_Name VARCHAR(50),/*ชื่อ */
    L_Name VARCHAR(50),/*นามสกุล*/
    Card  VARCHAR(20),/*บัตรประชาชน*/
    Address VARCHAR(20),/* ที่อยู่ */
    Tel VARCHAR(20),/*โทรศัพท์ */
    Salary NUMERIC(10, 5),/* เงินเดือน */
    Username VARCHAR(50),/* Username*/
    Password VARCHAR(50),/*Password */
    Stetus VARCHAR(50)/*สถานะ*/
);

--ข้อมูลลูกค้า/tblCus
CREATE TABLE tblCus (
    Id_Customer NUMERIC(10, 5) PRIMARY KEY,/*หมายเลขลูกค้า*/
    F_Name VARCHAR(50),/*ชื่อ*/
    L_Name VARCHAR(50),/*นามสกุล*/
    _Card  VARCHAR(20),/*บัตรประชาชน*/
    _Address VARCHAR(20),/*ที่อยู่*/
    Tel VARCHAR(20),/*โทรศัพท์*/
    Birthday  VARCHAR(20),/*วันเกิด*/
    Faith  VARCHAR(20),/*ศาสนา*/
    Nationality  VARCHAR(20),/*สัญชาติ*/
    Occupation  VARCHAR(20)/*อาชีพ*/
);

--ข้อมูลห้อง/tblRoom
CREATE TABLE tblRoom (
    ID_Room NUMERIC(10, 5) PRIMARY KEY,/* รหัสห้องพัก */
    Number_room NUMERIC(10, 5),/*หมายเลขห้อง*/
    Price_Room   Numeric(10,5),/* รายการของเบิก */
    _Status   Numeric(10,5)/*สถานะ */
);

--สัญญาเช่า/tblRent
CREATE TABLE tblRent (
    ID_rent NUMERIC(10, 5) PRIMARY KEY, /*หมายเลขสัญญาเช่า*/
    Money_insurance NUMERIC(10, 5),/*เงินค่ามัดจำ*/
    Start_Rcontract   VARCHAR(50),/*วันทำสัญญา*/
    End_Rcontract    VARCHAR(50),/*วันสิ้นสุดสัญญา*/
    _Date   Datetime  , /*วันที่*/
    Price_Panalty  Numeric(10,5),   /*ค่ามัดจำ*/
    Out_date    Datetime   ,/*วันที่ออก*/
    Id_Officer   NUMERIC(10, 5)   ,/*หมายเลขพนักงาน*/
    ID_Room   NUMERIC(10, 5)   ,/*หมายเลขห้อง */
    Id_Customer   Numeric(10,5)/*หมายเลขลูกค้า*/
);

--ใบแจ้งหนี้/tblInv
CREATE TABLE tblInv (
    ID_no   Numeric(10,5)  PRIMARY KEY,/*หมายเลขใบแจ้งหนี้*/
    Stetus  VARCHAR(20)  ,/*สถานะ*/
    Note Numeric(10,5)   ,/*หมายเหตุ*/
    ID_rent   Numeric(10,5)   , /*หมายเลขสัญญาเช่า*/
    _Date    Datetime   , /*วัน เดือน ปี*/
    Deadtime   Datetime   , /*กำหนดจ่าย*/
    ID_Room   Numeric(10,5)  ,  /*หมายเลขห้อง*/
    Id_Officer  Numeric(10,5)  /*หมายเลขพนักงาน*/
); 

--รำยละเอียดใบแจ้งหนี้/tblInvDetail
CREATE TABLE tblInvDetail (
    ID_Code    Numeric(10,5)   PRIMARY KEY, /*รหัสID*/
    ID_no    Numeric(10,5) ,/* หมายเลขใบแจ้งหนี้ */
    Name_Costs    VARCHAR(20)   ,/* ชื่อค่าใช้จ่าย */
    Price   Numeric(10,5)   ,/*ราคา */
    Unit     Numeric(10,5)   ,/*หน่วย*/
    _Date   Datetime  , /* วัน เดือน ปี */
    Penalty    Numeric(10,5)  , /* ปรับ */
    Other    VARCHAR(20)   ,/*อื่น ๆ*/
    Total     Numeric(10,5)   ,/*ยอดเงิน*/
    Deadtime   Datetime   ,/*กำหนดจ่าย*/
    Discount     Numeric(10,5) /*ส่วนลด*/
);

--ใบเสรํจรับเงิน/tblBill
CREATE TABLE tblBill (
    N_Bill NUMERIC(10, 5) PRIMARY KEY,/*หมายเลขใบเสร็จ */
    ID_no NUMERIC(10, 5),/*หมายเลขใบแจ้งหนี้*/
    _Date Datetime, /*วัน เดือน ปี */
    Total   Numeric(10,5),/*ยอดเงิน */
    N_statement  VARCHAR(50)/*หมายเลขใบแจ้งหนี้*/
);


ALTER TABLE tblRent
ADD CONSTRAINT FK_Employee_Rent
FOREIGN KEY (Id_Officer)
REFERENCES tblEmp(Id_Officer);

ALTER TABLE tblRent
ADD CONSTRAINT FK_Customer_Rent
FOREIGN KEY (Id_Customer)
REFERENCES tblCus(Id_Customer);

ALTER TABLE tblRent
ADD CONSTRAINT FK_Room_Rent
FOREIGN KEY (ID_Room)
REFERENCES tblRoom(ID_Room);


ALTER TABLE tblInv
ADD CONSTRAINT FK_Rent_Invoice
FOREIGN KEY (ID_rent)
REFERENCES tblRent(ID_rent);

ALTER TABLE tblInv
ADD CONSTRAINT FK_Emp_Invoice
FOREIGN KEY (Id_Officer)
REFERENCES tblEmp(Id_Officer);

ALTER TABLE tblInv
ADD CONSTRAINT FK_Room_Invoice
FOREIGN KEY (ID_Room)
REFERENCES tblRoom(ID_Room);


ALTER TABLE tblInvDetail
ADD CONSTRAINT FK_InvoiceDetail_Invoice
FOREIGN KEY (ID_no)
REFERENCES tblInv(ID_no);

ALTER TABLE tblBill
ADD CONSTRAINT FK_Bill_Invoice
FOREIGN KEY (ID_no)
REFERENCES tblInv(ID_no);