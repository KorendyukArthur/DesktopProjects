import unittest
import calc # тестируемый модуль

class TestCalc(unittest.TestCase):
    # начинается с test_
    def test_add(self):
        self.assertEqual(calc.add(3, 6), 9)

    # начинается с test_
    def test_is_positive(self):
        self.assertTrue(calc.is_positive(1))
        
if __name__ == "__main__":
    unittest.main()