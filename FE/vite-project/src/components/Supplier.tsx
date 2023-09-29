import React, { useEffect, useState } from 'react';
import { SupplierService } from '../services/SupplierService';
//import { ISupplierDetail } from '../models/ISupplierDetail';
import { ISupplierAmount } from '../models/ISupplierAmount';
import { ISupplierDetail } from '../models/ISupplierDetail';

const Supplier: React.FC = () => {
  let supplierID:number = 0;
  const [supplierData, setSupplierData] = useState<ISupplierAmount | null>(null);
  const [allSuppliers, setAllSuppliers] = useState<ISupplierDetail[]>([]);

  useEffect(() => {
    GetAllSuppliers();
  }, []);
  
  const GetSupplierAmount = (supplierID: number) => {
    SupplierService.getOrderAmountForSupplier(supplierID)
      .then((data) => {
        setSupplierData(data);
        console.log(supplierID);
      })
      .catch((error) => {
        console.error(error);
      });
  };

  const GetAllSuppliers = () => {
    SupplierService.getAllSuppliers()
      .then((data) => {
        setAllSuppliers(data);
      })
      .catch((error) => {
        console.error(error);
      });
  };

  const SelectSupplier = (event: React.ChangeEvent<HTMLSelectElement>) => {
    supplierID = parseInt(event.target.value, 10);
    console.log(supplierID);
  };

  

  return (
    <div>
    <h2>Supplier Data</h2>
    <div>
      <label>
        Select a Supplier:
        <select value={supplierID || ''} onChange={SelectSupplier}>
          <option value="" disabled>
            Select a supplier
          </option>
          {allSuppliers.map((supplier) => (
            <option key={supplier.supplierID} value={supplier.supplierID}>
              {supplier.companyName}
            </option>
          ))}
        </select>
      </label>
      <button onClick={() => GetSupplierAmount(supplierID)}>Get Data</button>
    </div>
    {supplierData && (
      <div>
        <p>Total Amount: {supplierData.totalAmount}</p>
      </div>
    )}
  </div>
  );
};

export default Supplier;