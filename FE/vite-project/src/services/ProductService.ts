
import { IProduct } from '../models/IProduct';

export const ProductService = {
    async getProducts(): Promise<IProduct[]> {
      try {
        const response = await fetch('https://localhost:7074/api/Data/GetData');
        if (!response.ok) {
          throw new Error('Network response was not ok');
        }
        const data = await response.json();
        return data as IProduct[];
      } catch (error) {
        throw new Error(`Error fetching products`);
      }
    },
  };