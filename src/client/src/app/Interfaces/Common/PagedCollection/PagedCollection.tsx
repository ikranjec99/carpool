export interface PagedCollection<T> {
    items: T[];
    totalCount: number;
    totalPages: number;
    pageNumber: number;
}