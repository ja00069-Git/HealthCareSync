MySql Stored Procedures

-----------------------

Jabesi
_________________________

CREATE PROCEDURE GetAvailableDoctorsByDate(IN appointment_date DATE)
BEGIN
    SELECT DISTINCT d.fname, d.lname
    FROM doctor_availability da
    JOIN doctor d ON da.doctor_id = d.id
    WHERE da.available_date = appointment_date AND da.isAvailable = 1;
END;

The above stored procedure will return the list of doctors who are available on the given date.

