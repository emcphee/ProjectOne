-- view to simplify readable flight details
CREATE VIEW FlightDetailsView AS
SELECT 
    F.flight_id,
    F.flight_number,
    F.departure_time,
    F.arrival_time,
    DEP.airport_name AS departure_airport,
    ARR.airport_name AS arrival_airport,
    CONCAT(P.first_name, ' ', P.last_name) AS pilot_name
FROM 
    Flights F
JOIN 
    Airports DEP ON F.departure_airport_id = DEP.airport_id
JOIN 
    Airports ARR ON F.arrival_airport_id = ARR.airport_id
JOIN 
    Pilots P ON F.pilot_id = P.pilot_id;