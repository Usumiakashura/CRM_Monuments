use Web_CRM_Monuments
SET IMPLICIT_TRANSACTIONS on
COMMIT

UPDATE MedallionMaterials SET Name = N'Фарфор' WHERE Id = 1
UPDATE MedallionMaterials SET Name = N'Керамика' WHERE Id = 2
UPDATE MedallionMaterials SET Name = N'Металлокерамика' WHERE Id = 3
UPDATE MedallionMaterials SET Name = N'Керамогранит' WHERE Id = 4
UPDATE MedallionMaterials SET Name = N'Стекло' WHERE Id = 5
DELETE FROM MedallionMaterials WHERE Id = 6

DELETE FROM ShapeMedallions WHERE Id = 1
DELETE FROM ShapeMedallions WHERE Id = 2
DELETE FROM ShapeMedallions WHERE Id = 3

SELECT * FROM MedallionSizes
SELECT * FROM PhotoOnMonuments
SELECT * FROM ShapeMedallions
SELECT * FROM MedallionMaterials

SELECT * FROM MedallionMaterialShapeMedallion
WHERE MedallionMaterialsId = 5


UPDATE PhotoOnMonuments SET ShapeMedallionId = NULL WHERE Id = 1
UPDATE PhotoOnMonuments SET ShapeMedallionId = NULL WHERE Id = 3
UPDATE PhotoOnMonuments SET MedallionSizeId = 2 WHERE Id = 1
UPDATE PhotoOnMonuments SET MedallionSizeId = 1 WHERE Id = 3
