import { ISupplierDetail } from '../models/ISupplierDetail';
import { ISupplierAmount } from '../models/ISupplierAmount';

export const SupplierService = {
    async getOrderAmountForSupplier(supplierID: number): Promise<ISupplierAmount> {
      try {
        const response = await fetch(`https://localhost:7074/api/Data/GetOrderAmountForSupplier?supplierID=${supplierID}`);
        if (!response.ok) {
          throw new Error('Network response was not ok');
        }
        const data = await response.json();
        return data;
      } catch (error) {
        throw new Error(`Error fetching order amount for supplier`);
      }
    },

    async getAllSuppliers(): Promise<ISupplierDetail[]> {
        try {
          const response = await fetch('https://localhost:7074/api/Data/GetAllSupliers');
          if (!response.ok) {
            throw new Error('Network response was not ok');
          }
          const data = await response.json();
          return data as ISupplierDetail[];
        } catch (error) {
          throw new Error(`Error fetching products`);
        }
      },
  };