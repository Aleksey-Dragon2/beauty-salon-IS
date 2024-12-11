from reportlab.lib import colors
from reportlab.lib.pagesizes import A4
from reportlab.lib.styles import getSampleStyleSheet, ParagraphStyle
from reportlab.lib.units import cm
from reportlab.platypus import SimpleDocTemplate, Paragraph, Spacer
from reportlab.pdfbase import pdfmetrics
from reportlab.pdfbase.ttfonts import TTFont

class BeautyReceiptPDF:
    def __init__(self):
        # Регистрация шрифта для поддержки кириллицы
        pdfmetrics.registerFont(TTFont('Arial', 'Arial.ttf'))
        
        self.styles = getSampleStyleSheet()
        # Создание стилей с поддержкой кириллицы
        self.styles.add(ParagraphStyle(
            name='CustomTitle',
            fontName='Arial',
            fontSize=16,
            alignment=1,
            spaceAfter=20
        ))
        self.styles.add(ParagraphStyle(
            name='CustomBody',
            fontName='Arial',
            fontSize=12,
            spaceAfter=10
        ))

    def generate_receipt(self, output_path, receipt_data):
        """
        Генерирует PDF чек
        
        receipt_data = {
            'number': '2024-0384',
            'date': '2024-12-11',
            'time': '14:30',
            'services': [
                {
                    'master': 'Иванова Анна Сергеевна',
                    'items': [
                        {'name': 'Стрижка женская', 'price': 2500},
                        {'name': 'Окрашивание волос', 'price': 5500}
                    ]
                },
                # Можно добавлять других мастеров и их услуги
            ]
        }
        """
        doc = SimpleDocTemplate(
            output_path,
            pagesize=A4,
            rightMargin=1*cm,
            leftMargin=1*cm,
            topMargin=1*cm,
            bottomMargin=1*cm
        )

        # Создаем список элементов для PDF
        elements = []

        # Заголовок
        elements.append(Paragraph("Салон красоты \"Афродита\"", self.styles['CustomTitle']))
        elements.append(Paragraph("пр. Черняховского, д. 14", self.styles['CustomBody']))
        elements.append(Paragraph("Тел: +375 (33) 123-45-67", self.styles['CustomBody']))
        elements.append(Spacer(1, 20))

        # Информация о чеке
        elements.append(Paragraph(f"Чек №{receipt_data['number']}", self.styles['CustomBody']))
        elements.append(Paragraph(f"Дата: {receipt_data['date']}", self.styles['CustomBody']))
        elements.append(Paragraph(f"Время: {receipt_data['time']}", self.styles['CustomBody']))
        elements.append(Spacer(1, 20))

        # Выводим услуги для каждого мастера
        total_amount = 0
        for service_group in receipt_data['services']:
            # Заголовок с именем мастера
            elements.append(Paragraph(f"Мастер: {service_group['master']}", self.styles['CustomBody']))
            
            # Перечисляем услуги и их стоимость
            for item in service_group['items']:
                elements.append(Paragraph(f"- {item['name']}: {item['price']} BYN", self.styles['CustomBody']))
                total_amount += item['price']

            elements.append(Spacer(1, 10))

        # Итоговая сумма
        elements.append(Spacer(1, 20))
        elements.append(Paragraph(f"ИТОГО К ОПЛАТЕ: {total_amount} BYN", self.styles['CustomTitle']))
        elements.append(Spacer(1, 20))

        # Футер
        elements.append(Paragraph("Спасибо за визит!", self.styles['CustomBody']))
        elements.append(Paragraph("Записаться на следующий визит:", self.styles['CustomBody']))
        elements.append(Paragraph("+375 (33) 123-45-67", self.styles['CustomBody']))

        # Создаем PDF
        doc.build(elements)

# Пример вызова метода получения данных и генерации чека
# with Session(engine) as session:
#     data = get_sample_data(visit_id=1, session=session)
#     receipt = BeautyReceiptPDF()
#     receipt.generate_receipt("output.pdf", data)
