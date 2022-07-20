export interface Employee {
  id: string;
  employeeId: number;
  employeeName: string;
  isDriver: boolean;
  createdAt?: Date;
  updatedAt?: Date;
  deletedAt?: Date;
}
