CREATE TRIGGER UpdateNumberOfFlights
ON Flights
AFTER INSERT
AS
BEGIN
    UPDATE Pilots
    SET P.number_of_flights = P.number_of_flights + 1
    FROM Pilots P
    JOIN inserted I ON P.pilot_id = I.pilot_id;
END;