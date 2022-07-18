export class TextHelper {
    public static cutText(text: string, maxLength: number): string {
        return text && text.length > maxLength ? text.substring(0, maxLength) : text
    }
}