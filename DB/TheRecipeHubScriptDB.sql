-------------Database creation-------------
--create database
Create database RecipeHubDB
GO
use RecipeHubDB
------------Table Creation-----------------
----------last version---------------------
--User Table
CREATE TABLE Users (
 UserID INT IDENTITY(1,1) PRIMARY KEY,
 FirstName VARCHAR(50) NOT NULL,
 LastName VARCHAR(50),
 Email VARCHAR(50) NOT NULL UNIQUE,
 Password VARCHAR(250) NOT NULL,
 Admin BIT NOT NULL DEFAULT 0
);
--Chef Table
CREATE TABLE Chef (
 ChefID INT IDENTITY(1,1) PRIMARY KEY,
 FirstName VARCHAR(50) NOT NULL,
 LastName VARCHAR(50),
 Email VARCHAR(50) NOT NULL UNIQUE,
 Password VARCHAR(250) NOT NULL,
 Bio VARCHAR(150),
 ISApproved BIT NOT NULL DEFAULT 1,
 FollowersCount INT,
 AdminID INT,
 FOREIGN KEY (AdminID) REFERENCES Users(UserID)
 ON DELETE SET NULL
 ON UPDATE CASCADE
);
--Nutritionist Table
CREATE TABLE Nutritionist(
 NutritionistID INT IDENTITY(1,1) PRIMARY KEY,
 FirstName VARCHAR(50) NOT NULL,
 LastName VARCHAR(50),
 Email VARCHAR(50) NOT NULL UNIQUE,
 Password VARCHAR(250) NOT NULL,
 Bio VARCHAR(150),
 ISApproved BIT NOT NULL DEFAULT 1,
 FollowersCount INT,
 AdminID INT,
 FOREIGN KEY (AdminID) REFERENCES Users(UserID)
 ON DELETE SET NULL
 ON UPDATE CASCADE
);
--Company Table
CREATE TABLE Company(
 CompanyID INT IDENTITY(1,1) PRIMARY KEY,
 Name VARCHAR(150) NOT NULL,
 Email VARCHAR(50) NOT NULL UNIQUE,
 Password VARCHAR(250) NOT NULL,
 Bio VARCHAR(150),
 ISApproved BIT NOT NULL DEFAULT 0,
 AdminID INT,
 FOREIGN KEY (AdminID) REFERENCES Users(UserID)
 ON DELETE SET NULL
 ON UPDATE CASCADE
);
--Ingredient Table
CREATE TABLE Ingredient (
 IngredientID INT IDENTITY (1,1) PRIMARY KEY,
 Name varchar(100) NOT NULL,
Calorie INT NOT NULL,
 NutritionalInfo varchar(150) 
);
--Recipe Table
CREATE TABLE Recipe(
 RecipeID INT IDENTITY (1,1) PRIMARY KEY,
 Name varchar(100) NOT NULL,
 Description varchar(300),
 Steps varchar(300),
 Image VARBINARY(MAX),
 Difficulty_Level INT NOT NULL,
 NutritionalInfo varchar(300),
 Cooking_Time INT NOT NULL,
 ChefID INT,
 FOREIGN KEY (ChefID) REFERENCES Chef(ChefID)
 ON UPDATE NO ACTION
 ON DELETE NO ACTION,
 NutritionistID INT,
 FOREIGN KEY (NutritionistID) REFERENCES Nutritionist(NutritionistID)
 ON DELETE NO ACTION
 ON UPDATE NO ACTION,
 CompanyID INT,
 FOREIGN KEY (CompanyID) REFERENCES Company(CompanyID)
 ON UPDATE NO ACTION
 ON DELETE NO ACTION,
);
--Collection Table (Partial Key Name)--
CREATE TABLE Collection (
CollectionName varchar(50),
Description varchar(300),
ChefID INT,
FOREIGN KEY (ChefID) REFERENCES Chef(ChefID)
ON UPDATE NO ACTION
ON DELETE NO ACTION,
RecipeID INT,
FOREIGN KEY (RecipeID) REFERENCES Recipe(RecipeID)
ON UPDATE NO ACTION
ON DELETE NO ACTION,
PRIMARY KEY(ChefID,CollectionName,RecipeID)
);
--Product Table
CREATE TABLE Product(
ProductID INT IDENTITY (1,1) PRIMARY KEY,
Name varchar(100) NOT NULL,
Description varchar(300),
CompanyID INT,
FOREIGN KEY (CompanyID) REFERENCES Company(CompanyID)
ON UPDATE NO ACTION
ON DELETE NO ACTION
);
--Collabs Table
CREATE TABLE Collabs (
Date DATE DEFAULT CURRENT_TIMESTAMP,
Description varchar(300),
CompanyID INT,
FOREIGN KEY (CompanyID) REFERENCES Company(CompanyID)
ON UPDATE NO ACTION
ON DELETE NO ACTION,
ChefID INT,
FOREIGN KEY (ChefID) REFERENCES Chef(ChefID)
ON UPDATE NO ACTION
ON DELETE NO ACTION,
PRIMARY KEY(Date,CompanyID,ChefID)
);
--List Table
CREATE TABLE AddToList (
ListType varchar(50),
UserID INT,
FOREIGN KEY (UserID) REFERENCES Users(UserID)
ON UPDATE NO ACTION
ON DELETE NO ACTION,
RecipeID INT,
FOREIGN KEY (RecipeID) REFERENCES Recipe(RecipeID)
ON UPDATE NO ACTION
ON DELETE NO ACTION,
PRIMARY KEY (ListType,UserID,RecipeID)
);
--Message Table
CREATE TABLE Message(
MessageID INT IDENTITY(1,1) PRIMARY KEY,
Content varchar (200) NOT NULL,
MessageType varchar(50) NOT NULL,
ChefID INT,
FOREIGN KEY (ChefID) REFERENCES Chef(ChefID)
ON UPDATE NO ACTION
ON DELETE NO ACTION,
UserID INT,
FOREIGN KEY (UserID) REFERENCES Users(UserID)
ON UPDATE NO ACTION
ON DELETE NO ACTION,
NutritionistID INT,
FOREIGN KEY (NutritionistID) REFERENCES Nutritionist(NutritionistID)
ON UPDATE NO ACTION
ON DELETE NO ACTION,
RecipeID INT,
FOREIGN KEY (RecipeID) REFERENCES Recipe(RecipeID)
ON UPDATE NO ACTION
ON DELETE NO ACTION
);
--Blog Posts Table
CREATE TABLE BlogPost(
BlogID INT IDENTITY(1,1) PRIMARY KEY,
Title varchar(100) NOT NULL,
Content varchar(MAX) NOT NULL,
DatePublished Date DEFAULT CURRENT_TIMESTAMP,
NutritionistID INT,
FOREIGN KEY (NutritionistID) REFERENCES Nutritionist(NutritionistID)
ON DELETE NO ACTION
ON UPDATE NO ACTION
);

--Diet Plan Table
CREATE TABLE DietPlan (
DPID INT IDENTITY(1,1),
Name varchar(150) NOT NULL,
Goal varchar(150) NOT NULL,
Description varchar(2000) NOT NULL,
NutritionistID INT,
FOREIGN KEY (NutritionistID) REFERENCES Nutritionist(NutritionistID)
ON DELETE NO ACTION
ON UPDATE NO ACTION,
PRIMARY KEY (DPID)
);

--Nutritionist Chosen Recipes in Diet Plan Table
CREATE TABLE ChosenRecipesForDietPlan(
DPID INT,
FOREIGN KEY (DPID) REFERENCES DietPlan(DPID)
ON UPDATE NO ACTION
ON DELETE NO ACTION,
RecipeID INT,
FOREIGN KEY (RecipeID) REFERENCES Recipe(RecipeID)
ON UPDATE NO ACTION
ON DELETE NO ACTION,
PRIMARY KEY (DPID,RecipeID)
);
--Like Table
CREATE TABLE Likes(
UserID INT,
FOREIGN KEY (UserID) REFERENCES Users(UserID)
ON UPDATE NO ACTION
ON DELETE NO ACTION,
RecipeID INT,
FOREIGN KEY (RecipeID) REFERENCES Recipe(RecipeID)
ON UPDATE NO ACTION
ON DELETE NO ACTION,
PRIMARY KEY (UserID,RecipeID)
);
--Rating Table
CREATE TABLE Rating(
UserID INT,
FOREIGN KEY (UserID) REFERENCES Users(UserID)
ON UPDATE NO ACTION
ON DELETE NO ACTION,
RecipeID INT,
FOREIGN KEY (RecipeID) REFERENCES Recipe(RecipeID)
ON UPDATE NO ACTION
ON DELETE NO ACTION,
Rating float NOT NULL,
PRIMARY KEY (UserID,RecipeID)
);
--Follow Nutritionist Table
CREATE TABLE Follow_Nutritionist(
UserID INT,
FOREIGN KEY (UserID) REFERENCES Users(UserID)
ON UPDATE NO ACTION
ON DELETE NO ACTION,
NutritionistID INT,
FOREIGN KEY (NutritionistID) REFERENCES Nutritionist(NutritionistID)
ON DELETE NO ACTION
ON UPDATE NO ACTION
);
--Follow Chef Table
CREATE TABLE Follow_Chef(
UserID INT,
FOREIGN KEY (UserID) REFERENCES Users(UserID)
ON UPDATE NO ACTION
ON DELETE NO ACTION,
ChefID INT,
FOREIGN KEY (ChefID) REFERENCES Chef(ChefID)
ON UPDATE NO ACTION
ON DELETE NO ACTION,
);
--Recipe Ingredients Table
CREATE TABLE RecipeIngredients(
IngredientID INT,
FOREIGN KEY (IngredientID) REFERENCES Ingredient(IngredientID)
ON UPDATE NO ACTION
ON DELETE NO ACTION,
SubstituteIngredientID INT,
FOREIGN KEY (SubstituteIngredientID) REFERENCES Ingredient(IngredientID)
ON UPDATE NO ACTION
ON DELETE SET NULL,
RecipeID INT,
FOREIGN KEY (RecipeID) REFERENCES Recipe(RecipeID)
ON UPDATE NO ACTION
ON DELETE NO ACTION,
PRIMARY KEY (IngredientID,RecipeID)
);


---------------------------INSERTIONS OF DATA------------------------------

INSERT INTO Users(FirstName, LastName, Email, Password, Admin) VALUES
('Raghad','Nabih','Raghad.Nabih@gmail.com','ef797c8118f02dfb649607dd5d3f8c7623048c9c063d532cc95c5ed7a898a64f',1),	--12345678
('Yousef','Kamel','Youssef12@gmail.com','9ac2197d9258257b1ae8463e4214e4cd0a578bc1517f2415928b91be4283fc48',1),	--ABCDEFGH
('Rana', 'Hassan', 'rana.hassan@gmail.com', 'd3dec3f35387156495cbc21471313f87155f878f3435b693f50077c2be479033', 0),	--Pass1234
('Omar', 'Abdelaziz', 'omar.abdelaziz@gmail.com', 'c3f2de5b97e590718766ad7be76f69c6a939390563977d27052a1caf7083ceb2', 0),	--SecureP@ss
('Fatma', 'Mohamed', 'fatma.mohamed@gmail.com', '540ad594751eab64005c3262bd65de17fd9063f05350980442e199a47ed9588a', 0),	--Qwerty@78
('Ahmed', 'Ali', 'ahmed.ali@gmail.com', 'cb8d9d617ef9051b148fdb7899a26f0e3ddb4e79ad2defce15f3ac9722f19d74', 0), --Ali-Ahmed9
('Laila', 'Khaled', 'laila.khaled@gmail.com', 'd83fdf752812320e39fb09f68bcbe7a575bf2db31160f38b66dd01ff09c1eae4', 0), --Laila2024
('Mohammed', 'Saad', 'mohammed.saad@gmail.com', 'c27c50ca742021d3f7e872bf88573c62f2ac2cc07288e50261c2ab948f0a4b69', 0),	--Saad!2023
('Sara', 'ElNemr', 'sara.elnemr@gmail.com', '9711fb8a4a6301a6a881c2d26f1b3b5a8a3ada1b57ac00bc9312a93f540491f7', 0),	--SaraNemr1
('Asmahan',NULL,'Asmahan@hotmail.com','30cf6ddc0dc3faa8e0f2ea72abb29db80de549101759b986b0a129db81804b0b',0),	--asmahan123
('Khalid', 'Ibrahim', 'khalid.ibrahim@yahoo.com', 'd7440805ab260d5ed42b3f16ea7f47d1df0e3db9b6becaad36dc04048762cb1a', 0),	--StrongPass1!
('Heba', 'Mahmoud', 'heba.mahmoud@outlook.com', 'f2ecc437b130a92258a8a6e075f0a171829876daa4d0fda1e445b22812627052', 0),	--Heba2023
('Karim', 'Abdullah', 'karim.abdullah@gmail.com', '2ed06766795d58a4f22d511a672f20a6b096d3fe5b56af3a744678a9a356fd82', 0), --Secret123
('Noor', 'Fawzy', 'noor.fawzy@hotmail.com', 'c77cd90302e4efe0d61fcd1989f60c4d6e99f717e4c76484ca463aeaba3cbd25', 0),	--NoorFawzy98
('Ibrahim', 'Youssef', 'ibrahim.youssef@gmail.com', '079191cbfd639cd0b101b7fe56ab000f9369b5cd1eed63f9ac738b76592256b6', 0),	--IbrahimY22
('Aisha', 'Ahmed', 'aisha.ahmed@yahoo.com', '8fd423979023e92158dbd89e587736dfd9c3bfad8ce1ab10b3666cb4a25994ec', 0),	--Aisha12345
('Judyd', 'Mohamed', 'judy.mohamed@outlook.com', '10c8ed4de5c51b506ef0c78d894b2ea65693c3379830ae5a0c6c5b008bc8ac05', 0),	--judeTheBest
('Haneen', 'Khalil', 'haneen.khalil@gmail.com', '8c42999a1c9e4bd655d969b2bd86ccf90d389fa8b1bf7ca9379f93339a7477c9', 0),	--Haneen2000
('Sami', 'Ibrahim', 'sami.ibrahim@hotmail.com', '1821eedf5b69d12a2be1aff9117408e265d78f454f90e18806ba3a63fea8b7f7', 0), --Sami1995
('Marwa', 'Saleh', 'marwa.saleh@yahoo.com', '12b915b390c240eb9901e045c3d3097cdf4fc90fab5f8be03392c9501e6e5433', 0);	--MarwaStrong

INSERT INTO Chef (FirstName, LastName, Email, Password, Bio, ISApproved, FollowersCount, AdminID) 
VALUES
('Nadia', 'El Sayed', 'nadia.elsayed@gmail.com', '333237777b64e8ada371811949e2c7971ec3075a5701f9438fb97329a3af4a0a', 'Dishes with ingredients from home', 1, 2500, 1),	--NadiaChef1
('Mohamed', 'Hazem', 'mohamed.hazem@gmail.com', '27c0ed40c3d18aa4188f91ba3b6bdcc45ca6bababab1bd6aa5d3cec439f7f444', 'Specializes in Middle Eastern cuisine.', 1, 180, 2),--ChefHazem23
('Amr', 'Sherif', 'amr.sherif@gmail.com', 'f8b8d49b3c93014df40ab9c5f21b6442a0517e412dd87c3392fd9240a4d6d385', 'Fusion cuisine and fine dining specialist.', 1, 3200, 1),	--AmrChef89
('Alaa', 'El Sherbiny', 'alaa.sherbiny@gmail.com', '154f4ae4621bf70487b146a29c6bc0468d42efa7f975390e9e69731da7de3ee4', 'TV personality and cookbook author.', 1, 4500, 1),	--AlaaCook88
('Gordon', 'Ramsay', 'gordon.ramsay@chefworld.com', 'aa2e0f3c3d634f8a67e1330ccfb36055e701ed92b5bc8ef0236875a0ec177378', 'Renowned British chef and restaurateur.', 1, 20000, 2),--Ramsay1234
('Mon3e4', NULL, 'monesh@chefmail.com', '5b43f83fff230a957c76a3afc2c38e145f6d89f73e5bb2d1e4c9ac807eb15bfb', 'Street food specialist and regional flavors.', 1, 1200, 2),--MoneshCook1
('Om-Khaled', Null, 'om.khaled@homestyle.com', '09dc7ee1124d7d58fed95530d92c6edbf3df403308c5595a3dae7e1fa76cf4ea', 'Homestyle cooking and hearty meals.', 1, 800, 2),--Om-khaled-3azama
('Omars', 'Cooking', 'omar.cooking@kitchenhub.com', 'bb9d586878a0775e8df62256f4421a67a42526fa7d4334dec229315a205c015f', 'Viral cooking sensation on social media.', 1, 5000, 1),--OmarFood45
('Manal', 'Al Alem', 'manal.alalem@chefworld.com', '7a39c35b5bdf8be3115bc8973e954a0f5585f43b40c673ed3c0969b0a8f53bd3', 'queen of Arabic desserts.', 1, 6000, 1),--ManalSweet1
('Sherbini', NULL, 'sherbini@egyptkitchen.com', '5534ad581deb0d06423335c33d24fd58bea50ef5fdad5cb503b6ed431d63285c', 'Ya 7arakato Ya takato', 1, 10000, 1);--Sherbini123

INSERT INTO Nutritionist (FirstName, LastName, Email, Password, Bio, ISApproved, FollowersCount, AdminID) 
VALUES
('Heba', 'Kotb', 'heba.kotb@gmail.com', '358c57ed475ceb5ea337c1bb79a1a78982c9dc017e2b52b63c4085690e1a7b47', 'Expert in nutrition for healthy living and weight management.', 1, 2500, NULL),--Healthy123
('Mona', 'El Sharnouby', 'mona.sharnouby@gmail.com', '33d32db6cc083860b36b29d533a6a58c9b865a94cf4ca470b17383777f819716', 'Specializes in pediatric nutrition and diet plans.', 1, 180, NULL),--NutritionMona1
('Ahmed', 'Magdy', 'ahmed.magdy@nutrition.com', '8f1b559444fcda33f4860b7d239964e343fdcf6480c2178fe7b3dcd6fda63630', 'Focuses on fitness and sports nutrition.', 1, 220, NULL),--FitLife789
('Asmaa', 'Khalil', 'asmaa.khalil@gmail.com', '08c98fbf9625d6ec9fc8e684c5508e9e2fb9190ddb0ce71b79fe7f5dcc6e55ff', 'Expert in therapeutic diets and meal planning.', 1, 1200, NULL),--Wellness45
('Nadia', 'Fouad', 'nadia.fouad@gmail.com', '8a89049ec8cfa1664694b5a6ef4dd3d81fd62ec07a579d202a5544394cb730f8', 'Promotes healthy eating habits for families.', 1, 210, NULL),--Dietitian1
('Sherine', 'Youssef', 'sherine.youssef@healthhub.com', '0ce248de2e64422131f68816e319593ee0c4ce2dfd1403f337fec8f979467776', 'Provides online courses on balanced diets.', 1, 300, NULL),--Sherine123
('Dina', 'Hassan', 'dina.hassan@gmail.com', 'a3eec6991462689af34023be1d32068ef1b5aa144e54aa7d92ea6a249057165d', 'Focuses on diet plans for chronic disease management.', 1, 150, NULL),--DinaFit12
('Mohamed', 'Adel', 'mohamed.adel@nutriworld.com', '721b981d1d46170773080399378bf4ff4bf6975e62b4c66efd853355256105d5', 'Specializes in bulking and weight loss programs.', 1, 180, NULL),--HealthyGuy7
('Fatma', 'Saad', 'fatma.saad@wellness.com', 'ffd2e3fc959d6d89b5995345c1fbd59220db4bd6be62a94001801405f9fcc1e1', 'Nutritionist known for her meal prep guides.', 1, 1700, NULL),--yala-n5es
('Yasmine', 'Tarek', 'yasmine.tarek@healthylife.com', 'a0563a40734c99f45e16a745b168a9216f4bbf8267bed8fc83c2a41f9efdd3a5', 'Focuses on vegan and vegetarian diet plans.', 1, 1900, NULL);--YasWellness

INSERT INTO Company (Name, Email, Password, Bio, ISApproved, AdminID) VALUES
('Koky', 'info@koky.com', 'ddfb771a9ca718cfe51f486a8193871842a0a98c883f8ff2b032b954b2f5c738', 'Leading company in producing frozen chicken products.', 1, 2),--KokyFood2023
('Borio', 'contact@borio.com', '2dd5d5df22795023a4aa83eecec1642eeeaf6aa08f40b27f243381d90b874439', 'Famous for its chocolate-filled biscuits.', 1, 2),--BorioSnacks12
('Halwani', 'support@halwani.com', 'fcaa82ad627ade4b8982e7e952f8231ca12c482f4a7998b146baca85fe5b91a8', 'Specializes in traditional Egyptian food products.', 1, 1),--HalwaniFoods45
('Edita', 'edita@snackfoods.com', '81e6ecdf116934e8a938ccbd7a72e99091c4e84691c695bbe9df01efdc676a0e', 'Market leader in packaged snack foods.', 1, 1),--EditaSnacks2023
('Faragello', 'info@faragello.com', '82f85bb1fa7d72aefa18b6ec3d389c0ea7b0e0c119a7a009138f7c5f324f5b37', 'producer of juices and canned food.', 1, 1),--FaragelloJuices
('Juhayna', 'juhayna@dairy.com', '5c7f9c66f20b3306d545f9ce40c2fc041df21e165675c872cca4735277ae30da', 'Famous for its dairy and juice products.', 1, 2),--JuhaynaMilk123
('Domty', 'contact@domty.com', '5573ce91309a6a53136e7bdc24c301a65b77c871b890ef69513ac6baa87d421a', 'Popular brand for cheese and bakery products.', 1, 1),--DomtyCheese45
('ElDoha', 'info@eldoha.com', 'e8b5225b091793a1264bcb63c25588671c06b8361876ab7db4583da79a83d1d1', 'Specializes in producing a variety of premium Pasta types', 1, 2),--ElDoha2023
('Bisco Misr', 'bisco@misr.com', 'd3e010c23c3bf723a7f8133c44a98ee46f21e54a2ecfe676dc701106cc84781b', 'Leading producer of biscuits and sweets.', 1, 1),--BiscoEgypt2023
('AbuAuf', 'support@abuauf.com', '5050ed165dc2f736b8e9bc5491647ffa00348fb60e854459c4427d52a244b26d', 'Known for its wide range of nuts, dried fruits, and health food products.', 1, 2);--AbuAufProducts

INSERT INTO Ingredient (Name, Calorie ,NutritionalInfo) VALUES
('Pasta', 100,'100g of pasta contains 131 kcal'),  --1
('Cream', 150,  'High in fat and calories.'), --2
('Butter', 100, NULL),--3
('Parmesan cheese', 431, '100g of Parmesan cheese contains 431 kcal. High in protein and fat.'),--4
('Chicken Breast', 45, 'Rich in lean protein, essential for muscle growth and repair'),--5
('Protein powder',456, NULL),--6
('Tomato',0, 'Packed with antioxidants like lycopene, good for heart health'),--7
('Cocoa powder',200, NULL),--8
('Olive Oil', 100,'1 tablespoon of olive oil contains 119 kcal'),--9
('Duck', 150, NULL),--10
('Garlic', 0,  'Boosts immune system and can help lower blood pressure'),--11
('Oranges',0, NULL),--12
('Onion', 0,  'Good source of fiber and antioxidants'),--13
('Soy sauce', 350, NULL),--14
('Chocolate chips', 250, '100g of chocolate chips contains 502 kcal. High in sugar and fat.'),--15
('Sugar', 300, NULL),--16
('Vinegar', 0, 'good for digestion '),--17
('Rice', 150, NULL),--18
('Eggs', 50, 'High in protein and packed with vitamins that promote healthy skin'),--19
('lemons', 0, NULL),--20
('Carrot', 0, 'Rich in vitamin A, supporting eye health and immune function'),--21
('Ginger', 0, NULL),--22
('Broccoli', 0, 'Loaded with vitamins and fiber, supporting healthy digestion'),--23
('Flour', 125,  Null),--24
('Honey', 100, 'Natural sweetener, good for energy.'),--25
('Pineapple',0, 'Rich in vitamin C and antioxidants.'),--26
('Lettuce', 0, 'Low in calories and high in water content, hydrating and refreshing'),--27
('Chickpeas', 50, NULL),--28
('Spinach', 0, 'High in iron, helping to prevent anemia'),--29
('Bell pepper',0,  NULL),--30
('Quinoa', 120, '100g of quinoa contains 120 kcal. High in protein and fiber.'),--31
('Ladyfingers', 500,  NULL),--32
('Mascarpone cheese', 430, '100g of mascarpone cheese contains 429 kcal. Rich in fat and creaminess.'),--33
('Cheddar Cheese', 429,'Not suitable for those with cholesterol issues'),--34
('Avocado', 23, NULL),--35
('Almonds', 25,'A good source of healthy fats'),--36
('Banana', 15, 'Great source of potassium,Avoid on keto or low-carb diets due to high sugar and carb content'),--37
('corn starch', 225, NULL),--38
('cocoa powder',300, NULL),--39
('Coffee',0,NULL),--40
('milk',0, 'good source of calcium'); --41

INSERT INTO Recipe (Name, Description, Steps, Difficulty_Level, NutritionalInfo, Cooking_Time, ChefID, NutritionistID, CompanyID) 
VALUES
('Alfredo Pasta', 'A creamy pasta with rich alfredo sauce', 'Boil pasta, prepare the sauce with butter, cream, and cheese, mix pasta and sauce.', 2, 'Contains 500 kcal per serving', 30, 5, NULL, NULL), 
('Sweet and Sour Chicken', 'Chicken with a tangy and sweet sauce', 'Cook chicken, prepare sweet and sour sauce, combine with chicken and serve.', 3, 'High in protein and carbs', 40, 3, NULL, NULL),
('Tiramisu', 'A classic Italian dessert made with coffee-soaked ladyfingers and mascarpone cream', 'Layer ladyfingers with mascarpone, soak in coffee, and refrigerate.', 2, 'Contains 350 kcal per serving', 50, 4, NULL, NULL),
('Orange Duck', 'A tender duck cooked with a flavorful orange glaze', 'Cook the duck, prepare the orange glaze, and drizzle it over the cooked duck.', 4, 'High in fat, moderate in protein', 60, 1, NULL, NULL),
('Cookies', 'Classic chocolate chip cookies', 'Mix ingredients, form dough balls, bake at 180°C for 12 minutes.', 1, 'Contains 150 kcal per cookie', 20, 8, NULL, NULL),
('Keto Salad', 'A low-carb salad with avocado and chicken', 'Toss lettuce, avocado, grilled chicken, and olive oil dressing.', 1, 'Great for keto diet, low-carb and high-fat', 15, NULL, 1, NULL),
('Protein Smoothie', 'A smoothie packed with protein and nutrients', 'Blend protein powder, almond milk, banana, and spinach.', 1, 'Good for muscle building, rich in protein', 10, NULL, 2, NULL),
('Vegan Bowl', 'A wholesome vegan bowl with quinoa, chickpeas, and veggies', 'Cook quinoa, add chickpeas and roasted veggies.', 2, 'Suitable for vegan diet, high in fiber and plant protein', 25, NULL, 3, NULL),
('Borio Cake', 'A delicious cake made with Borio biscuits', 'Crush Borio biscuits, mix with cream, form layers and refrigerate.', 2, 'A delicious treat, moderate in sugar', 30, NULL, NULL, 2),
('Pesto Pasta', 'A flavorful pasta with pesto sauce', 'Cook pasta, toss with homemade pesto sauce made from basil, garlic, and pine nuts.', 2, 'Contains 300 kcal per serving', 25, NULL, NULL, 8),
('Todo Cake', 'A chocolate cake made with Todo products', 'Prepare cake batter, bake and frost with Todo chocolate products.', 3, 'Sweet and delicious, high in sugar', 40, NULL, NULL, 4),
('Greek Salad', 'A fresh Greek salad with Domty cheese', 'Toss tomatoes, cucumbers, olives, and Domty cheese with olive oil and herbs.', 1, 'Low-calorie, great for healthy eating', 15, NULL, NULL, 7),
-- i added 5 chefs recipes, 3 nutritionist recipes,4 crecipes from companies--
('Risotto', 'A creamy and rich Italian rice dish.', 'Cook rice with stock, stir in Parmesan cheese.', 3, 'Contains 350 kcal per serving.', 45, 4, NULL, NULL), -- Alaa El Sherbiny
('Caprese Salad', 'A fresh Italian salad with mozzarella and basil.', 'Layer mozzarella, tomatoes, and basil leaves. Drizzle with olive oil.', 1, 'Low in calories, high in antioxidants.', 15, 4, NULL, NULL), -- Alaa El Sherbiny
('Beef Wellington', 'A luxurious dish with beef fillet and puff pastry.', 'Wrap beef in puff pastry and bake.', 4, 'Contains 600 kcal per serving.', 90, 5, NULL, NULL), -- Gordon Ramsay
('Scrambled Eggs', 'Perfectly creamy scrambled eggs.', 'Whisk eggs with butter, cook on low heat.', 1, 'High in protein and healthy fats.', 10, 5, NULL, NULL), -- Gordon Ramsay
('Chicken Casserole', 'A hearty dish with chicken and vegetables.', 'Bake chicken with vegetables in creamy sauce.', 3, 'Contains 400 kcal per serving.', 60, 3, NULL, NULL), -- Amr Sherif
('Stuffed Bell Peppers', 'Bell peppers filled with rice and vegetables.', 'Hollow bell peppers, stuff, and bake.', 2, 'High in fiber and vitamins.', 45, 3, NULL, NULL), -- Amr Sherif
('Grilled Chicken',NULL,'mix seasonings and add to chicken breasts, grill for 10 min on each side',3,NULL,25,1,NULL,NULL); --nadia el sayed
-- i added more recipes by chefs for the collection--

INSERT INTO Collection (CollectionName, Description, ChefID, RecipeID) VALUES
-- Collection for Alaa El Sherbiny
('Italian Dishes', 'Authentic Italian recipes perfect for any occasion.', 4, 3), -- Tiramisu
('Italian Dishes', 'Authentic Italian recipes perfect for any occasion.', 4, 13), -- Risotto
('Italian Dishes', 'Authentic Italian recipes perfect for any occasion.', 4, 14), -- Caprese Salad
-- Collection for Gordon Ramsay
('Fine Dining', 'Sophisticated recipes for special occasions.', 5, 1), -- Alfredo Pasta
('Fine Dining', 'Sophisticated recipes for special occasions.', 5, 15), -- Beef Wellington
('Fine Dining', 'Sophisticated recipes for special occasions.', 5, 16), -- Scrambled Eggs
-- Collection for Amr Sherif
('Comfort Classics', 'Hearty and satisfying dishes.', 3, 2), -- Sweet and Sour Chicken
('Comfort Classics', 'Hearty and satisfying dishes.', 3, 17), -- Chicken Casserole
('Comfort Classics', 'Hearty and satisfying dishes.', 3,18), -- Stuffed Bell Peppers
-- Collection for Nadia El Sayed
('Festive Flavors', 'Dishes perfect for celebrations.', 1, 4), -- Orange Duck
('Festive Flavors', 'Dishes perfect for celebrations.', 1, 19); --grilled chicken

INSERT INTO Product (Name, Description, CompanyID) VALUES  --3 products for each company--
('Frozen Chicken Breasts', NULL, 1),
('Chicken Nuggets', 'Crispy and delicious nuggets made from tender chicken.', 1),
('Chicken Wings', 'Marinated and ready-to-cook chicken wings.', 1),
('Borio milk chocholate', 'Classic biscuits filled with creamy chocolate.', 2),
('Borio white chocholate', 'Biscuits filled with creamy white chocolate.', 2),
('Borio dark chocholate', NULL, 2),
('Halwani Beef Pastrami', 'Authentic beef pastrami made with traditional spices.', 3),
('Halwani Molokhia', 'Frozen and finely chopped Egyptian molokhia.', 3),
('Halwani Foul Medames', 'Ready-to-eat Egyptian-style fava beans.', 3),
('Todo Chocolate Cake', 'Moist chocolate cake filled with rich cream.', 4),
('Molto Croissant', 'Soft croissant with a chocolate or vanilla filling.', 4),
('Bake Rolls', 'Crunchy baked snacks in assorted flavors.', 4),
('Faragello Orange Juice', 'Freshly squeezed orange juice in a bottle.', 5),
('Faragello Pineapple Juice', 'Exotic pineapple juice for a tropical taste.', 5),
('Faragello Mixed Fruit Nectar', 'A refreshing blend of various fruits.', 5),
('Juhayna Full Cream Milk', 'Rich and creamy milk for daily use.', 6),
('Juhayna Mango Juice', 'Delicious mango-flavored juice.', 6),
('Juhayna Yogurt', 'Creamy and fresh yogurt perfect for snacking.', 6),
('Domty White Cheese', 'Classic soft white cheese for every meal.', 7),
('Domty Cheddar Cheese', 'Rich and sharp cheddar cheese.', 7),
('Domty Cheese Croissant', 'Fluffy croissant filled with Domty cheese.', 7),
('El Doha Spaghetti', 'Classic long pasta for Italian dishes.', 8),
('El Doha Penne', 'Tube-shaped pasta for creamy or baked dishes.', 8),
('El Doha Vermicelli', 'Thin pasta perfect for soups or desserts.', 8),
('Bisco Digestive Biscuits', 'Healthy and delicious digestive biscuits.', 9),
('Bisco Butter Cookies', NULL, 9),
('Bisco Wafer Bars', 'Crispy wafer bars coated in chocolate.', 9),
('Abu Auf Mixed Nuts', 'A healthy blend of almonds, cashews, and pistachios.', 10),
('Abu Auf Dried Mango', Null, 10),
('Abu Auf Coffee Beans', 'Premium coffee beans for a perfect brew.', 10);

INSERT INTO Collabs (Description, CompanyID, ChefID) VALUES
('Chef Nadia El Sayed collaborating with Faragello', 5, 1),
('Chef Alaa El Sherbiny collaborating with Domty', 7, 4),
('Chef Mohamed Hazem collaborating with Halwani', 3, 2),
('Chef Amr Sherif collaborating with Edita', 4, 3),
('Chef Gordon Ramsay collaborating with Juhayna', 6, 5);

INSERT INTO AddToList (ListType, UserID, RecipeID) VALUES
('Shopping List', 3, 1),
('Shopping List', 8, 6),
('Shopping List', 5, 9),
('Tried List', 1, 3), 
('Tried List', 7, 5),
('Tried List', 8, 2), 
('To-Cook List', 9, 7), 
('To-Cook List', 3, 10), 
('To-Cook List', 1, 1),
('To-Cook List', 4, 7), 
('To-Cook List', 4, 10), 
('To-Cook List', 4, 1),
('Favorite List', 5, 2), 
('Favorite List', 6, 9), 
('Favorite List', 4, 8);  

INSERT INTO BlogPost (Title, Content, NutritionistID) VALUES
('Healthy Snacks','Discover easy and nutritious snack ideas for busy days, focusing on balance and energy.', 1), 
('Weight Loss Tips','Learn effective strategies for sustainable weight loss, including portion control and meal planning.',2), 
('Allergy Guide', 'Understand common food allergies, symptoms, and how to manage them effectively', 4),
('Vegan Diets', 'Explore the essentials of transitioning to a vegan lifestyle, including nutritional considerations.',10),
('Boost Immunity', 'Learn how to strengthen your immune system through food, vitamins, and healthy habits.', 7);

INSERT INTO Message (Content, MessageType, UserID, RecipeID) VALUES
('Great work on the Alfredo Pasta!', 'Comment', 3, 1), 
('Looks delicious! Can’t wait to try the Sweet and Sour Chicken', 'Comment', 1, 2),
('What is the substitute for Parmesan cheese in Alfredo Pasta?', 'Question', 5, 1), 
('How can I make the Tiramisu less sweet?', 'Question', 6, 3),
('The Orange Duck recipe is outstanding!', 'Comment', 7, 4); -- User Laila

INSERT INTO Message (Content, MessageType, ChefID,NutritionistID, RecipeID) VALUES
('Try using less sugar in the Tiramisu for a lighter dessert.', 'comment', null,5, 3),
('To make the Tiramisu less sweet, reduce the sugar in the cream mixture.', 'Reply', 4,null, 3),
('Add more vegetables to Sweet and Sour Chicken for extra fiber.', 'Comment', null,4, 2),
('Consider using low-fat cream for Alfredo Pasta to make it healthier.', 'Comment', NUll,1, 1),
('You can substitute Parmesan cheese with Romy cheese', 'Reply', 5,null, 1);


INSERT INTO DietPlan (Name, Goal, Description, NutritionistID) VALUES 
('Weight Loss Plan', 'Weight Loss', 'A low-calorie diet focused on weight loss, incorporating lean proteins, vegetables, and healthy fats', 1),
('Muscle Gain Plan', 'Muscle Gain', 'A high-protein diet designed to support muscle growth with a balance of carbs and healthy fats', 2),
('Keto Diet', 'Weight Loss', 'A low-carb, high-fat diet to induce ketosis for fat burning and weight loss', 3),
('Vegetarian Plan', 'Weight Loss', 'A plant-based diet promoting weight loss while ensuring balanced nutrition from fruits, vegetables, and grains.', 4),
('Diabetic-Friendly Diet', 'Blood Sugar Control', 'A diet focused on managing blood sugar levels, featuring low glycemic index foods and controlled portion sizes', 5),
('Heart-Healthy Plan', 'Heart Health', 'A heart-healthy diet to reduce cholesterol and improve cardiovascular health, rich in omega-3 fatty acids and fiber', 6);

INSERT INTO ChosenRecipesForDietPlan (DPID, RecipeID) VALUES
(1,16),
(2,7),
(3,6),
(4,8),
(5,18),
(6,19);

INSERT INTO Likes(UserID, RecipeID) VALUES
(1,2),
(1,3),
(1,4),
(2,8),
(2,18),
(2,19),
(3,2),
(3,3),
(3,4),
(4,7),
(4,1),
(5,17),
(7,11),
(9,12),
(8,3),
(10,14);

INSERT INTO Rating (UserID, RecipeID, Rating) VALUES
(1,1,5),
(2,1,4.8),
(3,3,3.3),
(1,2,3),
(4,3,5),
(8,7,4.8);

INSERT INTO Follow_Nutritionist (UserID, NutritionistID) VALUES
(1,2),
(1,3),
(1,4),
(2,8),
(8,7),
(2,5),
(10,2),
(3,3),
(3,4),
(4,7),
(4,1),
(5,7),
(7,3),
(9,3),
(8,2),
(10,9);

INSERT INTO Follow_Chef (UserID, ChefID) VALUES
(1,2),
(1,3),
(1,4),
(2,8),
(8,7),
(2,5),
(10,2),
(3,3),
(3,4),
(4,7),
(4,1),
(5,7),
(7,3),
(9,3),
(8,2),
(10,9);

INSERT INTO RecipeIngredients (IngredientID, SubstituteIngredientID, RecipeID) VALUES
(1, NULL, 1),  -- Pasta, Alfredo Pasta
(2, NULL, 1),  -- Cream, Alfredo Pasta
(3, NULL, 1),  -- Butter, Alfredo Pasta
(4, NULL, 1),  -- Parmesan Cheese, Alfredo Pasta
(5, NULL, 2),  -- Chicken Breast, Sweet and Sour Chicken
(14, NULL, 2), -- Soy Sauce, Sweet and Sour Chicken
(16, 15, 2),  -- Sugar, Honey, Sweet and Sour Chicken
(17, NULL, 2), -- Vinegar, Sweet and Sour Chicken
(38, NULL, 2), -- Cornstarch, Sweet and Sour Chicken
(32, NULL, 3), -- Ladyfingers, Tiramisu
(33, NULL, 3), -- Mascarpone Cheese, Tiramisu
(19, NULL, 3), -- Eggs, Tiramisu
(16, 15, 3),  -- Sugar, Honey, Tiramisu
(8, NULL, 3),  -- Cocoa Powder, Tiramisu
(40, NULL, 3), -- Coffee, Tiramisu
(10, NULL, 4), -- Duck, Orange Duck
(12, NULL, 4), -- Orange, Orange Duck
(14, NULL, 4), -- Soy Sauce, Orange Duck
(25, NULL, 4), -- Honey, Orange Duck
(11, NULL, 4), -- Garlic, Orange Duck
(22, NULL, 4), -- Ginger, Orange Duck
(24, NULL, 5), -- Flour, Cookies
(16, 15, 5),  -- Sugar, Honey, Cookies
(3, NULL, 5),  -- Butter, Cookies
(19, NULL, 5), -- Eggs, Cookies
(15, NULL, 5), -- Chocolate Chips, Cookies
(27, NULL, 6), -- Lettuce, Keto Salad
(35, NULL, 6), -- Avocado, Keto Salad
(5, NULL, 6),  -- Chicken Breast, Keto Salad
(9, NULL, 6),  -- Olive Oil, Keto Salad
(20, NULL, 6), -- Lemon Juice, Keto Salad
(6, NULL, 7),  -- Protein Powder, Protein Smoothie
(41, NULL, 7),  -- Milk, Protein Smoothie
(37, NULL, 7), -- Banana, Protein Smoothie
(29, NULL, 7), -- Spinach, Protein Smoothie
(31, NULL, 8), -- Quinoa, Vegan Bowl
(28, NULL, 8), -- Chickpeas, Vegan Bowl
(30, NULL, 8), -- Bell Pepper, Vegan Bowl
(23, NULL, 8), -- Broccoli, Vegan Bowl
(21, NULL, 8), -- Carrot, Vegan Bowl
(9, NULL, 8),  -- Olive Oil, Vegan Bowl
(24, NULL, 10), -- Flour, Pesto Pasta
(29, NULL, 10), -- Spinach (Basil), Pesto Pasta
(4, NULL, 10),  -- Parmesan Cheese, Pesto Pasta
(9, NULL, 10),  -- Olive Oil, Pesto Pasta
(11, NULL, 10); -- Garlic, Pesto Pasta



