INSERT INTO Products 
(Name, Brand, Category, Price, Description, ImageFileName, CreatedAt)
VALUES
('Cabernet Sauvignon Reserve', 'Silver Oak', 'Red', 89.99, 
 'A full-bodied Napa Valley Cabernet Sauvignon aged in American oak barrels, rich with dark berry and vanilla flavors.', 
 'silveroak_reserve.jpg', GETDATE()),

('Chardonnay Classic', 'Kendall-Jackson', 'White', 18.99, 
 'Creamy and smooth California Chardonnay with tropical fruit and oak notes. Perfect for seafood or creamy pasta.', 
 'kj_chardonnay.jpg', GETDATE()),

('Brut Cuvée', 'Veuve Clicquot', 'Sparkling', 54.50, 
 'Premium French Champagne with fine bubbles and balanced citrus, apple, and brioche notes. Ideal for celebrations.', 
 'veuve_brt.jpg', GETDATE()),

('Pinot Noir Estate', 'La Crema', 'Red', 26.75, 
 'Silky and elegant Pinot Noir from Sonoma Coast with flavors of cherry, raspberry, and subtle spice.', 
 'lcrema_pinot.jpg', GETDATE()),

('Sauvignon Blanc', 'Cloudy Bay', 'White', 21.50, 
 'New Zealand Sauvignon Blanc with intense tropical aromas and crisp acidity. A refreshing summer wine.', 
 'cloudy_sauvblc.jpg', GETDATE()),

('Rosé d’Provence', 'Whispering Angel', 'Rosé', 22.00, 
 'Pale pink rosé from Provence, dry and smooth with hints of strawberries and citrus. Very popular.', 
 'angel_rose.jpg', GETDATE());
