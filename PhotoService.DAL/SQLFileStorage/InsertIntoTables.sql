ALTER DATABASE PhotoService COLLATE Cyrillic_General_CI_AS;

insert into Roles (Title) values('Менеджер'), ('Исполнитель'), ('Заказчик')

insert into Types (Title, IsDeleted) values('Фотограф', 0),
('Видеограф', 0), ('Ретушер', 0), ('Дизайнер', 0), ('Модель', 0),
('Визажист', 0), ('Стилист', 0), ('Предоставление красивых мест для съёмки', 0),
('Предоставление специально оборудованных помещений для проведения съёмки', 0), ('Организация съёмочного процесса', 0)

insert into Users (RoleId, Password, Name, Mail, Phone, SpecializationId, Dossier, Rating, IsBlocked, IsDeleted, URL, ExecutorType, CompanyTitle, INN, OGRN, IsDenied, ReasonDenied)
values(1, '123455', 'Иван Петрович Веселов', 'hsdht@hard', '89663542334', null, null, null, 0, 0, null, null, null, null, null, 0, null),
    (1, '123456', 'Денис Валерьевич Мдень', 'ardh@har', '89568659666', null, null, null, 0, 0, null, null, null, null, null, 0, null),
    (1, '123457', 'Антон Васильевич Грида', 'dqawFD@rgsg', '89342678009', null, null, null, 0, 0, null, null, null, null, null, 0, null),

    (2, '12344', 'Ангелина Владиславовна Мнишек', 'afw@hjst', '89895346675', 1, null, null, 0, 0, 'www', 'Юрлицо', 'Шарашкина контора', 132, 123, 0, null),
    (2, '12345', 'Арсений Артемьевич Серебрянников', 'av@vv', '89678003904', 1, null, null, 0, 0, 'как-то так', 'Самозанятый', null, 111, null, 0, null),
    (2, '12346', 'Иванов Иван Иванович', 'dawa@fe', '89356786879', 1, null, null, 0, 0, 'какая-то ссылка', 'ИП', 'ИИИ', 123, 132, 0, null),
    (2, '12347', 'Елизавета Александровна Михеева', 'vdvd@dsejdvDfek', '89233445675', 1, null, null, 0, 0, 'чё-то там', 'Самозанятый', null, 222, null, 0, null),

    (3, '1233', 'Дядя Вася', 'VD@mm', null, null, null, null, 0, 0, null, null, null, null, null, 0, null),
    (3, '1234', 'Баба Саша', 'fzbn@nzgt', null, null, null, null, 0, 0, null, null, null, null, null, 0, null),
    (3, '1235', 'Тётя Клава', 'gdeakueh@dsejdfek', null, null, null, null, 0, 0, null, null, null, null, null, 0, null)

insert into Services (ExecutorId, TypeId, Title, Description, Price, IsDeleted) values(4, 1, 'Съёмка Ваших мероприятий', 'Супер-дупер-ультра', 'От 1500 р./ч.', 0),
    (5, 1, 'Портретная съёмка в студии', 'Лучше всех', '5 000р. за 3 часа', 0), (6, 1, 'Свадебный фотограф', 'Ничего не упущу', '15 000 р. за съёмочный день', 0),
    (7, 1, 'Фотограф-анималист', 'Животные меня любят', '3000 р./ч.', 0)

insert into Orders (CustomerId, CreationDate, Comment, ServiceId, CanceledReason, Status, IsDeleted)
values(8, '2024-04-04', 'Какой-то комментарий', 1, null, 'Новый', 0),
    (8, '2024-04-04', 'Какой-то комментарий', 2, null, 'В работе', 0),
    (8, '2024-04-04', 'Какой-то комментарий', 3, null, 'Завершён', 0),
    (8, '2024-04-04', 'Какой-то комментарий', 4, 'Исполнитель не сможет выполнить работу в желаемую дату.', 'Отменён', 0)

insert into Reviews (Mark, Review, OrderId, Status, IsDeleted) values(5, 'Некий текст', 1, 'Создан', 0), (5, 'Некий текст', 2, 'На проверке', 0),
    (5, 'Некий текст', 3, 'Опубликован', 0), (5, 'Некий текст', 4, 'Отклонён', 0)

insert into Complains (AuthorId, Complain, RecipientId, Status, IsDeleted) values(4, 'Жалоба', 8, 'Создан', 0), (5, 'Жалоба', 9, 'На проверке', 0),
    (6, 'Жалоба', 10, 'Опубликован', 0), (10, 'Жалоба', 4, 'Отклонён', 0)

-- drop table Roles
-- drop table Types
-- drop table Users
-- drop table Services
-- drop table Orders
-- drop table Reviews
-- drop table Complains