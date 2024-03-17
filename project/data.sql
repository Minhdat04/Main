SELECT * FROM movieRoom
SELECT * FROM moviewScheduleDetail
SELECT * FROM memberAccount

SELECT * FROM movieTicket
SELECT * FROM moviewScheduleDetail

ALTER TABLE employeeAccount
ALTER COLUMN role VARCHAR(10) NOT NULL;

INSERT INTO memberAccount (memAccId, memUserName, [password], memName, birthday, phone, [status])
VALUES 
    (1, 'mem1', '12345678', N'Nguyễn Văn A', '1990-05-20', '123456789', 1),
    (2, 'mem2', '12345678', N'Nguyễn Thị B', '1985-10-15', '987654321', 1),
    (3, 'mem3', '12345678', N'Trần Văn C', '1995-03-25', '555555555', 0),
    (4, 'mem4', '12345678', N'Lê Thị D', '1988-12-01', '999999999', 1);

INSERT INTO employeeAccount (empAccId, empUserName, [password], empName, phone, [role], [status])
VALUES 
    (1, 'admin', '1234', N'Lê Đại Quyền', '1234567890', 'admin', 1),
    (2, 'staff1', '12345', N'Quyền Lê', '9876543210', 'staff', 1),
    (3, 'staff2', '123456', N'Lê Quyền', '5555555555', 'staff', 1);

INSERT INTO movieSchedule (movieScheId, timeSlot)
VALUES
	('Ca 1', '7:00:00 - 10:00:00')


INSERT INTO movieRoom (movieRoomID, movieRoomName, sitPlaceTotal, status)
VALUES 
    (1, N'Rạp 1', 25, 1),
    (2, N'Rạp 2', 25, 1),
    (3, N'Rạp 3', 25, 1);
