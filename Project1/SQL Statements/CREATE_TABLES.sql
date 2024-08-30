-- Airports table to store information about airports
CREATE TABLE Airports (
    airport_id INT IDENTITY PRIMARY KEY,
    airport_code VARCHAR(10) UNIQUE NOT NULL,
    airport_name VARCHAR(100) NOT NULL,
    city VARCHAR(100) NOT NULL,
    country VARCHAR(100) NOT NULL,
    image_url VARCHAR(512) NULL
);

-- Pilots table to store information about pilots
CREATE TABLE Pilots (
    pilot_id INT IDENTITY PRIMARY KEY,
    first_name VARCHAR(100) NOT NULL,
    last_name VARCHAR(100) NOT NULL,
    license_number VARCHAR(50) UNIQUE NOT NULL,
    experience_years INT NOT NULL, -- this cant be calculated with a start date because they might not always be working
    number_of_flights INT NOT NULL
);

-- Flights table to store information about flights
CREATE TABLE Flights (
    flight_id INT IDENTITY PRIMARY KEY,
    flight_number VARCHAR(20) UNIQUE NOT NULL,
    departure_airport_id INT NOT NULL,
    arrival_airport_id INT NOT NULL,
    departure_time DATETIME NOT NULL,
    arrival_time DATETIME NOT NULL,
    pilot_id INT NOT NULL,
    FOREIGN KEY (departure_airport_id) REFERENCES Airports(airport_id),
    FOREIGN KEY (arrival_airport_id) REFERENCES Airports(airport_id),
    FOREIGN KEY (pilot_id) REFERENCES Pilots(pilot_id)
);

-- Tickets table to store information about flight tickets
CREATE TABLE Tickets (
    ticket_id INT IDENTITY PRIMARY KEY,
    flight_id INT NOT NULL,
    customer_id INT NOT NULL,
    seat_number VARCHAR(6) NOT NULL,
    booking_date DATETIME NOT NULL,
    price DECIMAL(10, 2) NOT NULL,
    FOREIGN KEY (flight_id) REFERENCES Flights(flight_id),
    FOREIGN KEY (customer_id) REFERENCES Customers(customer_id)
);

-- API keys
CREATE TABLE API_Keys (
   api_id INT IDENTITY PRIMARY KEY,
   api_key CHAR(32) NOT NULL,
   permission_level INT NOT NULL
);