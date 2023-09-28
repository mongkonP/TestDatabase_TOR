IF OBJECT_ID('tblEmp', 'U') IS NOT NULL
BEGIN
    DROP TABLE tblEmp;
    PRINT 'Delete table tblEmp complete';
END
IF OBJECT_ID('tblCus', 'U') IS NOT NULL
BEGIN
    DROP TABLE tblCus;
     PRINT 'Delete table tblCus complete';
END
IF OBJECT_ID('tblRoom', 'U') IS NOT NULL
BEGIN
    DROP TABLE tblRoom;
     PRINT 'Delete table tblRoom complete';
END
IF OBJECT_ID('tblRent', 'U') IS NOT NULL
BEGIN
    DROP TABLE tblRent;
     PRINT 'Delete table tblRent complete';
END
IF OBJECT_ID('tblInv', 'U') IS NOT NULL
BEGIN
    DROP TABLE tblInv;
     PRINT 'Delete table tblInv complete';
END
IF OBJECT_ID('tblInvDetail', 'U') IS NOT NULL
BEGIN
    DROP TABLE tblInvDetail;
     PRINT 'Delete table tblInvDetail complete';
END
IF OBJECT_ID('tblBill', 'U') IS NOT NULL
BEGIN
    DROP TABLE tblBill;
     PRINT 'Delete table tblBill complete';
END
