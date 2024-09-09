CREATE TRIGGER UpdateNumberOfFlights
ON Flights
AFTER INSERT
AS
BEGIN
    UPDATE Pilots
    SET number_of_flights = number_of_flights + 1
    FROM Pilots P
    JOIN inserted I ON P.pilot_id = I.pilot_id;
END;