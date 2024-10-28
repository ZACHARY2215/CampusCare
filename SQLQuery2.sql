CREATE TABLE Doctors (
    doctor_id int identity(1,1) not null,
    first_name varchar(50) not null,
    last_name varchar(50) not null,
    email varchar(100) not null,
    role varchar(10) not null,
    contact_number bigint not null,
    status varchar(12) not null,
    CONSTRAINT PK_DoctorID PRIMARY KEY CLUSTERED (doctor_id ASC),
    CONSTRAINT CHK_Role CHECK (role IN ('nurse', 'doctor')),
    CONSTRAINT CHK_Status CHECK (status IN ('available', 'unavailable'))
);

