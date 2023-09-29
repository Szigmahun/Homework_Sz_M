export interface IProduct{
    productID: number,
    productName: string,
    supplierID :number,
    categoryID:number,
    quantityPerUnit:string,
    unitPrice:number,
    unitsInStock :number,
    reorderLevel: number,
    discontinued:boolean
}