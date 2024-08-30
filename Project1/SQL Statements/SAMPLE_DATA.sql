INSERT INTO Airports (airport_code, airport_name, city, country, image_url)
VALUES 
('JFK', 'John F. Kennedy International Airport', 'New York', 'USA', 'https://metroairportnews.com/wp-content/uploads/T4_Exterior1-768x471.jpg'),
('LHR', 'Heathrow Airport', 'London', 'UK', 'https://media.cntraveler.com/photos/5942a76c57d01262a807f8f8/1:1/w_2592,h_2592,c_limit/GettyImages-175377092.jpg'),
('NRT', 'Narita International Airport', 'Tokyo', 'Japan', 'https://upload.wikimedia.org/wikipedia/commons/9/98/Narita_International_Air_Port_%28cropped%29.jpg'),
('DXB', 'Dubai International Airport', 'Dubai', 'UAE', 'https://media.cnn.com/api/v1/images/stellar/prod/210623180928-dubai-airport.jpg'),
('SYD', 'Sydney Kingsford Smith Airport', 'Sydney', 'Australia', 'https://www.world-airport-codes.com/content/uploads/2013/08/SYD_mark_merton_kingsfordsmithairportpic_nhfw38h3b4.jpg');

INSERT INTO Pilots (first_name, last_name, license_number, experience_years, number_of_flights)
VALUES 
('John', 'Doe', 'A1234567', 15, 2500),
('Jane', 'Smith', 'B2345678', 10, 1800),
('Carlos', 'Gonzalez', 'C3456789', 20, 3000),
('Emily', 'Wong', 'D4567890', 8, 1200),
('Ahmed', 'Al-Masri', 'E5678901', 12, 2200);

INSERT INTO Flights (flight_number, departure_airport_id, arrival_airport_id, departure_time, arrival_time, pilot_id)
VALUES 
('AA101', 1, 2, '2024-09-01 08:00:00', '2024-09-01 12:00:00', 1),
('BA202', 2, 3, '2024-09-02 09:00:00', '2024-09-02 20:00:00', 2),
('JL303', 3, 4, '2024-09-03 10:00:00', '2024-09-03 18:00:00', 3),
('EK404', 4, 5, '2024-09-04 11:00:00', '2024-09-04 23:00:00', 4),
('QF505', 5, 1, '2024-09-05 13:00:00', '2024-09-05 23:00:00', 5);

INSERT INTO Tickets (flight_id, customer_id, seat_number, booking_date, price)
VALUES 
(1, 101, '12A', '2024-08-15 14:00:00', 500.00),
(2, 102, '15B', '2024-08-16 15:00:00', 750.00),
(3, 103, '20C', '2024-08-17 16:00:00', 1000.00),
(4, 104, '1A', '2024-08-18 17:00:00', 1500.00),
(5, 105, '30D', '2024-08-19 18:00:00', 1200.00);
