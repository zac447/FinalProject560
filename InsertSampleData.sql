
INSERT INTO HR.Employee
(ManagerID, LastName, FirstName, DateOfBirth, Title, DateOfHire, [Status], HourlyRate)
VALUES
(NULL, 'Johnson', 'Mark', '1980-04-12', 'General Manager', '2010-06-01', 'Active', 55.00), 
(1, 'Smith', 'Laura', '1985-09-21', 'Project Manager', '2015-03-15', 'Active', 45.00),  
(1, 'Anderson', 'Kevin', '1983-01-08', 'Lead Carpenter', '2014-09-10', 'Active', 40.00), 
(2, 'Brown', 'Emily', '1990-02-14', 'Junior Carpenter', '2019-07-22', 'Active', 28.50),    
(2, 'Martinez', 'Carlos', '1988-11-05', 'Electrician', '2018-01-12', 'Active', 32.75),  
(1, 'Davis', 'Rachel', '1987-03-30', 'Project Manager', '2016-04-18', 'Active', 44.00),   
(3, 'Wilson', 'Peter', '1979-07-19', 'Plumber', '2012-10-03', 'Active', 33.00),    
(3, 'Taylor', 'Hannah', '1992-06-25', 'Painter', '2020-02-05', 'Active', 26.00),   
(6, 'Thomas', 'Liam', '1991-08-11', 'Site Supervisor', '2017-08-14', 'Active', 38.00),   
(6, 'White', 'Sophia', '1993-12-02', 'Designer', '2021-01-09', 'Active', 31.50),   
(2, 'Lee', 'Daniel', '1984-10-10', 'Estimator', '2013-05-20', 'Active', 36.25),   
(2, 'Hall', 'Olivia', '1995-01-17', 'Office Admin', '2022-06-01', 'Active', 22.00),    
(1, 'Young', 'Ethan', '1982-09-03', 'Operations Lead', '2011-08-22', 'Active', 48.00),   
(3, 'Harris', 'Zoe', '1994-05-27', 'Carpenter', '2020-09-10', 'Active', 29.00),         
(7, 'Clark', 'Mason', '1989-11-29', 'Plumber', '2017-11-15', 'Active', 33.50),               
(5, 'Lewis', 'Ava', '1991-04-06', 'Electrician', '2019-03-19', 'Active', 32.25),             
(9, 'Robinson', 'Noah', '1986-02-22', 'Site Tech', '2018-07-30', 'Active', 27.75),           
(9, 'Walker', 'Mia', '1993-09-09', 'Site Tech', '2021-10-01', 'Active', 26.50),              
(6, 'Perez', 'Lucas', '1987-01-25', 'Project Coordinator', '2016-12-05', 'Active', 34.00),   
(13, 'Hill', 'Grace', '1990-07-14', 'Quality Inspector', '2018-04-23', 'Active', 35.50);     


INSERT INTO Sales.Customer
(Email, LastName, FirstName, Phone, [Address], City, [State], ZipCode, [Status])
VALUES
('alice.williams@example.com',  'Williams',  'Alice',   '5551110001', '101 Main St',          'Chicago',    'IL', '60601', 'Active'),
('bob.jones@example.com',       'Jones',     'Bob',     '5551110002', '202 Oak Ave',          'Naperville', 'IL', '60540', 'Active'),
('carla.morris@example.com',    'Morris',    'Carla',   '5551110003', '303 Pine St',          'Aurora',     'IL', '60505', 'Active'),
('dan.turner@example.com',      'Turner',    'Dan',     '5551110004', '404 Maple Dr',         'Elgin',      'IL', '60120', 'Active'),
('eva.garcia@example.com',      'Garcia',    'Eva',     '5551110005', '505 Cedar Rd',         'Joliet',     'IL', '60431', 'Active'),
('frank.miller@example.com',    'Miller',    'Frank',   '5551110006', '606 Birch Ln',         'Chicago',    'IL', '60602', 'Active'),
('grace.thompson@example.com',  'Thompson',  'Grace',   '5551110007', '707 Spruce Ct',        'Schaumburg', 'IL', '60173', 'Active'),
('henry.adams@example.com',     'Adams',     'Henry',   '5551110008', '808 Walnut St',        'Oak Park',   'IL', '60302', 'Active'),
('irene.ward@example.com',      'Ward',      'Irene',   '5551110009', '909 Chestnut Blvd',    'Evanston',   'IL', '60201', 'Active'),
('jack.brooks@example.com',     'Brooks',    'Jack',    '5551110010', '110 Ash St',           'Cicero',     'IL', '60804', 'Active'),
('karen.reed@example.com',      'Reed',      'Karen',   '5551110011', '121 Elmwood Ave',      'Berwyn',     'IL', '60402', 'Active'),
('liam.foster@example.com',     'Foster',    'Liam',    '5551110012', '131 Oakwood Dr',       'Tinley Park','IL', '60477', 'Active'),
('mia.coleman@example.com',     'Coleman',   'Mia',     '5551110013', '141 Highland Rd',      'Palatine',   'IL', '60067', 'Active'),
('noah.rivera@example.com',     'Rivera',    'Noah',    '5551110014', '151 Lakeview Dr',      'Bolingbrook','IL', '60440', 'Active'),
('olivia.hughes@example.com',   'Hughes',    'Olivia',  '5551110015', '161 Hillcrest Ln',     'Downers Gro','IL', '60515', 'Active'),
('paul.ross@example.com',       'Ross',      'Paul',    '5551110016', '171 Ridge Rd',         'Elmhurst',   'IL', '60126', 'Active'),
('quinn.sanders@example.com',   'Sanders',   'Quinn',   '5551110017', '181 Forest Dr',        'Lombard',    'IL', '60148', 'Active'),
('rachel.long@example.com',     'Long',      'Rachel',  '5551110018', '191 Willow St',        'Glendale Hg','IL', '60139', 'Active'),
('samuel.powell@example.com',   'Powell',    'Samuel',  '5551110019', '201 Parkside Ave',     'Wheaton',    'IL', '60187', 'Active'),
('tina.barnes@example.com',     'Barnes',    'Tina',    '5551110020', '211 Prairie St',       'Hoffman Est','IL', '60169', 'Active');


INSERT INTO Sales.ProjectProposal
(ProjectName, ProjectDetails, CustomerID, EstimatedDurationHours, [Status])
VALUES
('Kitchen Remodel - Williams', 'Full kitchen renovation: cabinets, counters, flooring.',                1, 120, 'Proposed'),
('Bathroom Upgrade - Jones',   'New tub, vanity, tile floor, updated lighting.',                         2,  80, 'Approved'),
('Basement Finish - Morris',   'Frame, drywall, electrical, and flooring for basement living space.',   3, 200, 'Proposed'),
('Deck Build - Turner',        'Build 300 sq ft wood deck with railing.',                               4,  60, 'Approved'),
('Living Room Update - Garcia','New flooring, paint, and recessed lighting.',                           5,  40, 'Proposed'),
('Bedroom Remodel - Miller',   'Master bedroom repaint, new flooring, and closet buildout.',            6,  50, 'Proposed'),
('Office Renovation - Thompson','Convert spare room into home office with built-ins.',                  7,  70, 'Proposed'),
('Garage Upgrade - Adams',     'Insulate and drywall garage, add storage.',                             8,  65, 'Proposed'),
('Kitchen Refresh - Ward',     'Cabinet refacing and backsplash install.',                              9,  55, 'Approved'),
('Patio Addition - Brooks',    'Concrete patio with seating wall.',                                    10,  45, 'Proposed'),
('Basement Bar - Reed',        'Custom bar, cabinets, and plumbing for basement.',                     11, 110, 'Proposed'),
('Sunroom Add - Foster',       'Three-season sunroom addition.',                                       12, 150, 'Proposed'),
('Bathroom Add - Coleman',     'Add full bath on second floor.',                                      13, 130, 'Proposed'),
('Kitchen Expand - Rivera',    'Knock down wall and expand kitchen footprint.',                        14, 160, 'Proposed'),
('Exterior Siding - Hughes',   'Replace existing siding with fiber cement.',                           15, 140, 'Proposed'),
('Window Replace - Ross',      'Replace 12 windows with energy-efficient units.',                      16,  50, 'Approved'),
('Laundry Room - Sanders',     'Remodel laundry room with cabinets and sink.',                         17,  60, 'Proposed'),
('Dining Room - Long',         'Wainscoting, new lighting, and paint.',                                18,  35, 'Proposed'),
('Home Theater - Powell',      'Basement home theater framing, sound, lighting.',                      19, 180, 'Proposed'),
('Entryway Update - Barnes',   'New tile, paint, and custom storage bench in entryway.',               20,  30, 'Proposed');


INSERT INTO Production.Project
(CustomerID, ProjectName, StartDate, EndDate, ManagerID, [Status])
VALUES
(1,  'KitchenR1', '2024-03-01', NULL,        2,  'InProgress'),
(2,  'BathR1',    '2024-01-15', '2024-03-10',2,  'Completed'),
(3,  'BaseR1',    '2024-04-01', NULL,        3,  'InProgress'),
(4,  'DeckR1',    '2024-02-10', NULL,        6,  'InProgress'),
(5,  'LivingR1',  '2024-03-20', NULL,        6,  'NotStarted'),
(6,  'BedR1',     '2024-05-01', NULL,        2,  'InProgress'),
(7,  'OfficeR1',  '2024-04-15', NULL,        6,  'InProgress'),
(8,  'GarageR1',  '2024-02-20', '2024-04-05',3,  'Completed'),
(9,  'KitRef1',   '2024-01-25', '2024-03-01',2,  'Completed'),
(10, 'PatioR1',   '2024-03-05', NULL,        6,  'InProgress'),
(11, 'BarR1',     '2024-05-10', NULL,        3,  'NotStarted'),
(12, 'SunRmR1',   '2024-06-01', NULL,        6,  'NotStarted'),
(13, 'BathAdd1',  '2024-04-25', NULL,        2,  'InProgress'),
(14, 'KitExp1',   '2024-03-30', NULL,        3,  'InProgress'),
(15, 'SidingR1',  '2024-02-01', '2024-04-20',6,  'Completed'),
(16, 'WindowR1',  '2024-01-10', '2024-02-15',2,  'Completed'),
(17, 'LaundryR1', '2024-03-18', NULL,        3,  'InProgress'),
(18, 'DiningR1',  '2024-02-25', '2024-03-20',6,  'Completed'),
(19, 'TheaterR1', '2024-05-05', NULL,        2,  'InProgress'),
(20, 'EntryR1',   '2024-03-01', NULL,        3,  'InProgress');


INSERT INTO Production.ProjectRateType
(ProjectID, HourlyRate, StartDate, EndDate)
VALUES
(1,  45.00, '2024-03-01', NULL),
(2,  43.00, '2024-01-15', '2024-03-10'),
(3,  46.50, '2024-04-01', NULL),
(4,  44.00, '2024-02-10', NULL),
(5,  42.00, '2024-03-20', NULL),
(6,  45.50, '2024-05-01', NULL),
(7,  44.75, '2024-04-15', NULL),
(8,  43.50, '2024-02-20', '2024-04-05'),
(9,  44.25, '2024-01-25', '2024-03-01'),
(10, 43.75, '2024-03-05', NULL),
(11, 46.00, '2024-05-10', NULL),
(12, 47.00, '2024-06-01', NULL),
(13, 45.25, '2024-04-25', NULL),
(14, 46.75, '2024-03-30', NULL),
(15, 42.50, '2024-02-01', '2024-04-20'),
(16, 41.00, '2024-01-10', '2024-02-15'),
(17, 43.25, '2024-03-18', NULL),
(18, 42.75, '2024-02-25', '2024-03-20'),
(19, 47.50, '2024-05-05', NULL),
(20, 42.25, '2024-03-01', NULL);


INSERT INTO Production.ProjectMaterials
(ProjectID, [Description], Quantity, Total)
VALUES
(1,  'Cabinets',                20,  6000.00),
(1,  'Granite Countertops',      3,  4500.00),
(2,  'Tile Flooring',           120, 2400.00),
(2,  'Vanity & Sink',            1,   900.00),
(3,  'Drywall Sheets',           80, 1200.00),
(3,  'Recessed Lighting Cans',  24,  720.00),
(4,  'Pressure Treated Lumber', 60, 1800.00),
(4,  'Deck Screws & Hardware',  10,  300.00),
(5,  'Laminate Flooring',       25, 1750.00),
(5,  'Interior Paint',           8,  320.00),
(6,  'Carpet & Padding',        30, 2100.00),
(6,  'Closet Hardware',         10,  400.00),
(7,  'Built-in Desk Materials', 15, 1500.00),
(7,  'Office Lighting',          6,  480.00),
(8,  'Insulation Batts',        40,  600.00),
(8,  'Garage Drywall',          50,  900.00),
(9,  'Backsplash Tile',         30,  750.00),
(9,  'Cabinet Refacing',        20, 1100.00),
(10, 'Concrete',                15,  900.00),
(10, 'Pavers',                  30, 1500.00),
(11, 'Bar Cabinets',            12, 2400.00),
(11, 'Plumbing Fixtures',        4,  800.00),
(12, 'Sunroom Windows',         14, 4200.00),
(12, 'Roofing Panels',          10, 3000.00),
(13, 'Shower Unit',              1, 1500.00),
(13, 'Tile & Waterproofing',    60, 1800.00),
(14, 'LVL Beams',                4, 2200.00),
(14, 'Framing Lumber',          30,  900.00),
(15, 'Fiber Cement Siding',     80, 5600.00),
(15, 'House Wrap',              10,  500.00),
(16, 'Replacement Windows',     12, 4800.00),
(16, 'Flashing & Caulk',        12,  360.00),
(17, 'Laundry Cabinets',        10, 1600.00),
(17, 'Utility Sink & Faucet',    1,  450.00),
(18, 'Wainscoting Panels',      25, 1250.00),
(18, 'Chandelier',               1,  350.00),
(19, 'Acoustic Panels',         40, 2000.00),
(19, 'Projector & Screen',       1, 2500.00),
(20, 'Entryway Tile',           20,  700.00),
(20, 'Built-in Bench Lumber',   12,  480.00);


INSERT INTO Production.ProjectHours
(ProjectID, EmployeeID, [Description], WorkPerformedDate, [Hours])
VALUES
(1,  3,  'Demo old cabinets and counters',      '2024-03-02', 8),
(1,  5,  'Rough electrical in kitchen',         '2024-03-04', 6),
(1,  7,  'Rough plumbing adjustments',          '2024-03-05', 5),
(1,  8,  'Drywall patch and prep',              '2024-03-07', 7),

(2,  3,  'Remove old tub and vanity',           '2024-01-16', 7),
(2,  5,  'New tub and plumbing install',        '2024-01-18', 8),
(2,  8,  'Tile shower walls and floor',         '2024-01-22', 8),
(2,  14, 'Grout and cleanup',                   '2024-01-24', 5),

(3,  3,  'Frame basement walls',                '2024-04-02', 8),
(3,  7,  'Install electrical boxes',            '2024-04-03', 7),
(3,  5,  'Run circuits and panel connections',  '2024-04-05', 6),
(3,  8,  'Hang drywall on framed walls',        '2024-04-08', 8),

(4,  3,  'Layout and footings for deck',        '2024-02-11', 6),
(4,  9,  'Set posts and beams',                 '2024-02-13', 7),
(4,  14, 'Install deck boards',                 '2024-02-15', 8),

(5,  8,  'Remove carpet and prep subfloor',     '2024-03-21', 6),
(5,  10, 'Paint walls and trim',                '2024-03-23', 7),

(6,  3,  'Remove old flooring in bedroom',      '2024-05-02', 6),
(6,  8,  'Install new hardwood',                '2024-05-04', 8),
(6,  10, 'Closet build-out framing',            '2024-05-06', 7),

(7,  8,  'Demo room and patch walls',           '2024-04-16', 6),
(7,  10, 'Install built-in desk framing',       '2024-04-18', 7),
(7,  11, 'Electrical for outlets and lights',   '2024-04-19', 5),

(8,  7,  'Install insulation in walls',         '2024-02-21', 7),
(8,  8,  'Hang and tape drywall',               '2024-02-23', 8),

(9,  3,  'Cabinet refacing prep',               '2024-01-26', 6),
(9,  8,  'Install backsplash tile',             '2024-01-28', 7),

(10, 14, 'Excavate and prep patio area',        '2024-03-06', 5),
(10, 3,  'Form and pour concrete',              '2024-03-07', 8),
(10, 14, 'Install seating wall',                '2024-03-09', 7),

(11, 3,  'Layout basement bar framing',         '2024-05-11', 6),
(11, 5,  'Rough plumbing for bar sink',         '2024-05-13', 5),

(12, 3,  'Foundation prep for sunroom',         '2024-06-02', 7),
(12, 7,  'Frame sunroom walls and roof',        '2024-06-04', 8),

(13, 5,  'Rough plumbing and venting',          '2024-04-26', 7),
(13, 3,  'Frame bathroom walls',                '2024-04-27', 6),

(14, 3,  'Demo wall for expansion',             '2024-03-31', 7),
(14, 7,  'Install LVL support beam',            '2024-04-02', 8),

(15, 3,  'Remove old siding',                   '2024-02-02', 7),
(15, 14, 'Install new fiber cement siding',     '2024-02-05', 8),

(16, 3,  'Remove old windows',                  '2024-01-11', 6),
(16, 7,  'Install new units and seal',          '2024-01-13', 7),

(17, 8,  'Demo old laundry fixtures',           '2024-03-19', 5),
(17, 10,'Install cabinets and counters',        '2024-03-21', 7),

(18, 8,  'Install wainscoting panels',          '2024-02-26', 6),
(18, 10,'Paint and finish dining room',         '2024-02-28', 7),

(19, 3,  'Frame theater walls and riser',       '2024-05-06', 7),
(19, 7,  'Run low-voltage wiring',              '2024-05-08', 6),
(19, 8,  'Install acoustic panels',             '2024-05-10', 5),

(20, 8,  'Demo old tile and baseboard',         '2024-03-02', 5),
(20, 10,'Install new tile and trim',            '2024-03-03', 7);
