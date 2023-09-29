
import React, { useEffect, useState } from 'react';
import { IProduct } from '../models/IProduct';
import { ProductService } from '../services/ProductService';

const Products: React.FC = () => {
  const [products, setProducts] = useState<IProduct[]>([]);

  useEffect(() => {
    ProductService.getProducts()
      .then((data) => {
        console.log(data)
        setProducts(data);
      })
      .catch((error) => {
        console.error(error);
      });
  }, []);

  return (
    <div>
      <h2>Products</h2>
      <table className="table">
        <thead>
          <tr>
            <th>Product ID</th>
            <th>Product Name</th>
            <th>Supplier ID</th>
            <th>Category ID</th>
            <th>Quantity Per Unit</th>
            <th>Unit Price</th>
            <th>Units In Stock</th>
            <th>Reorder Level</th>
            <th>Discontinued</th>
          </tr>
        </thead>
        <tbody>
          {products.map((product) => (
            <tr key={product.productID}>
              <td>{product.productID}</td>
              <td>{product.productName}</td>
              <td>{product.supplierID}</td>
              <td>{product.categoryID}</td>
              <td>{product.quantityPerUnit}</td>
              <td>{product.unitPrice}</td>
              <td>{product.unitsInStock}</td>
              <td>{product.reorderLevel}</td>
              <td>{product.discontinued ? 'Yes' : 'No'}</td>
            </tr>
          ))}
        </tbody>
      </table>
    </div>
  );
};

export default Products;