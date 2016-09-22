using RimWorld;
using System;
using System.Linq;
using Verse;

namespace Hello
{
    [StaticConstructorOnStartup]
    public class Inject
    {
        static Inject()
        {
        
            foreach (Backstory current in BackstoryDatabase.allBackstories.Values)
            {
            	// Adulthood
                if (current.title == "Actor")
				{
               		current.title = "Переводчик модов";
               		current.titleShort = "Переводчик";
               		current.baseDesc = "NAME воспитывалась что бы готовить бутерброды, однако запомнить что колбаса должны быть сверху ей так и не удалось. В итоге все бросив и бежав на ЧУЖБИНУ, занялась переводом модов на давно забытый мертвый язык.";
					//current.baseDesc = "
                }
                if (current.title == "Colony settler")
                {
                	current.title = "Полесенец";
                	current.titleShort = "Полесенец";
                	current.baseDesc = "NAME was a settler on a new colony world.\n\nSuch a life requires a jack-of-all trades at basic hands-on tasks.";
                }
                if (current.title == "Medieval farm oaf")
                {
                	current.title = "Средневековый селюк";
                	current.titleShort = "Селюк";
                	current.baseDesc = "Tilling, hoeing, guiding ox carts, pushing wheelbarrows. Digging ditches, planting seeds, predicting the harvest.\n\nMedieval-level farmers aren't educated in the usual sense, but they know a lot about growing plants without technology. That said, such a life leaves one essentially incapable of participating in intellectual, technology-driven activities.";
                }
                if (current.title == "Medieval lord")
                {
                	current.title = "Средневековый господин";
                	current.titleShort = "Благородный";
                	current.baseDesc = "NAME was a lord on a preindustrial planet. HECAP went to parties, managed the underlings, and even learned some swordplay.\n\nHISCAP soft hands did not hold a work tool during that entire time. HECAP considers manual labor to be beneath HIM.";
                }
                if (current.title == "Urbworld entrepreneur")
                {
                	current.title = "Городской предпринимаель";
                	current.titleShort = "Предпринимаель";
                	current.baseDesc = "In the urbworlds, most suffer. But someone has to run the corporations.\n\nNAME learned the skills of the trade - greasing palms and technical analysis. HECAP is a sociointellectual machine.";
                }
                if (current.title == "Deep space miner")
                {
                	current.title = "Шахтер дальнего космоса";
                	current.titleShort = "Шахтер";
                	current.baseDesc = "NAME did the sweaty, grimy work of pulling metal out of asteroids on a deep space rig. HECAP used HIS hands-on industrial skills daily - and wasn't bad in a bar fight either.";
                }
                if (current.title == "Navy scientist")
                {
                	current.title = "Ученый ВМФ";
                	current.titleShort = "Ученый";
                	current.baseDesc = "Interstellar warfare is won by technology, so imperial navies are always on the peak of modern research. Even better, they have first access to Transcendent artifacts because they find them in space.\n\nNAME worked in a navy lab.";
                }
                if (current.title == "Military commissar")
                {
                	current.title = "Военный комиссар";
                	current.titleShort = "Комиссар";
                }
                if (current.title == "Space pirate")
                {
                	current.title = "Космический пират";
                	current.titleShort = "Пират";
                }
                if (current.title == "Pit brawler")
                {
                	current.title = "Борец в грязи";
                	current.titleShort = "Борец";
                }
                if (current.title == "Illegal shipwright")
                {
                	current.title = "Нелегальный корабел";
                	current.titleShort = "Корабел";
                }
                if (current.title == "Courtesean")
                {
                	current.title = "Куртизанка";
                	current.titleShort = "Куртизанка";
                }
                if (current.title == "Space marine")
                {
                	current.title = "Космический морпех";
                	current.titleShort = "Морпех";
                }
                if (current.title == "Assassin")
                {
                	current.title = "Наемный убийца";
                	current.titleShort = "Убийца";
                }
                if (current.title == "Hermit")
                {
                	current.title = "Отшельник";
                	current.titleShort = "Отшельник";
                }
                if (current.title == "Midworld chef")
                {
                	current.title = "Повас с Мидворда";
                	current.titleShort = "Повар";
                }
                if (current.title == "Sickly child")
                {
                	current.title = "Болезненый ребенок";
                	current.titleShort = "Пациент";
                }
                if (current.title == "Medieval minstrel")
                {
                	current.title = "Средневековый певец";
                	current.titleShort = "Певец";
                }
                if (current.title == "Housemate")
                {
                	current.title = "Сосед";
                	current.titleShort = "Сосед";
                }
                if (current.title == "Glitterworld empath")
                {
                	current.title = "Эмпат";
                	current.titleShort = "Эмпат";
                }
                if (current.title == "Shelter child")
                {
                	current.title = "Ребенок с убежища";
                	current.titleShort = "Дитя убежища";
                }
                if (current.title == "Medieval doctor")
                {
                	current.title = "Средневековый доктор";
                	current.titleShort = "Шарлатан";
                }
                if (current.title == "Inventor")
                {
                	current.title = "Изобретатель";
                	current.titleShort = "Изобретатель";
                }
                if (current.title == "Teacher")
                {
                	current.title = "Учитель";
                	current.titleShort = "Учитель";
                }
                if (current.title == "Industrial orphan")
                {
                	current.title = "Промышленый сирота";
                	current.titleShort = "Сирота";
                }
                if (current.title == "Scout")
                {
                	current.title = "Скаут";
                	current.titleShort = "Скаут";
                }
                if (current.title == "Joywire artist")
                {
                	current.title = "Артист";
                	current.titleShort = "Артист";
                }
                if (current.title == "Frightened child")
                {
                	current.title = "Испуганое дитя";
                	current.titleShort = "Испуганый";
                }
                if (current.title == "Conceptual artist")
                {
                	current.title = "Концептуальный артист";
                	current.titleShort = "Артист";
                }
                if (current.title == "Glitterworld surgeon")
                {
                	current.title = "Современный хирург";
                	current.titleShort = "Хирург";
                }
                if (current.title == "Luddite rebel")
                {
                	current.title = "Бунтарь Луддитов";
                	current.titleShort = "Луддит";
                }
                if (current.title == "Bartender")
                {
                	current.title = "Бармен";
                	current.titleShort = "Бармен";
                }
                if (current.title == "Caveworld tender")
                {
                	current.title = "Пещерный молодец";
                	current.titleShort = "Пещеророжденый";
                }
                if (current.title == "Caveworld tunneler")
                {
                	current.title = "Пещерокопатель";
                	current.titleShort = "Копатель";
                }
                if (current.title == "Pyromaniac")
                {
                	current.title = "Пироманьяк";
                	current.titleShort = "Пироман";
                }
                if (current.title == "House servant")
                {
                	current.title = "Домашный слуга";
                	current.titleShort = "Слуга";
                }
                if (current.title == "Bodyguard")
                {
                	current.title = "Телохранитель";
                	current.titleShort = "Телохранитель";
                }
                if (current.title == "Novelist")
                {
                	current.title = "Новелист";
                	current.titleShort = "Новелист";
                }
                if (current.title == "Mathematician")
                {
                	current.title = "Математик";
                	current.titleShort = "Математик";
                }
                if (current.title == "Paramedic")
                {
                	current.title = "Парамедик";
                	current.titleShort = "Парамедик";
                }
                if (current.title == "Castaway")
                {
                	current.title = "Потерпевший кораблекрушение";
                	current.titleShort = "Потерпевший";
                }
                if (current.title == "Gardener")
                {
                	current.title = "Садовник";
                	current.titleShort = "Садовник";
                }
                if (current.title == "Mafia boss")
                {
                	current.title = "Босс мафии";
                	current.titleShort = "Босс";
                }
                if (current.title == "Torturer")
                {
                	current.title = "Мучитель";
                	current.titleShort = "Мучитель";
                }
                if (current.title == "Construction engineer")
                {
                	current.title = "Инженер проектировщик";
                	current.titleShort = "Строитель";
                }
                if (current.title == "Blacksmith")
                {
                	current.title = "Кузнец";
                	current.titleShort = "Кузнец";
                }
                if (current.title == "Charity worker")
                {
                	current.title = "Благотворительный работник";
                	current.titleShort = "Альтруист";
                }
                if (current.title == "Defector")
                {
                	current.title = "Дезертир";
                	current.titleShort = "Дезертир";
                }
                if (current.title == "Factory worker")
                {
                	current.title = "Фабричный разнорабочий";
                	current.titleShort = "Разнорабочий";
                }
                if (current.title == "Ranch owner")
                {
                	current.title = "Владелец ранчо";
                	current.titleShort = "Фермер";
                }
                if (current.title == "Low-wage worker")
                {
                	current.title = "Чернорабочий";
                	current.titleShort = "Чернорабочий";
                }
                if (current.title == "Model")
                {
                	current.title = "Модель";
                	current.titleShort = "Модель";
                }
                if (current.title == "Taxonomist")
                {
                	current.title = "Таксономист";
                	current.titleShort = "Таксономист";
                }
                if (current.title == "Geologist")
                {
                	current.title = "Геолог";
                	current.titleShort = "Геолог";
                }
                if (current.title == "Tactician")
                {
                	current.title = "Тактик";
                	current.titleShort = "Тактик";
                }
                if (current.title == "Glitterworld officer")
                {
                	current.title = "Офицер высшего света";
                	current.titleShort = "Офицер";
                }
                if (current.title == "Taster")
                {
                	current.title = "Дегустатор";
                	current.titleShort = "Дегустатор";
                }
                if (current.title == "Biosphere manager")
                {
                	current.title = "Ботаник";
                	current.titleShort = "Ботаник";
                }
                if (current.title == "Veterinarian")
                {
                	current.title = "Ветеринар";
                	current.titleShort = "Ветеринар";
                }
                if (current.title == "Explosives expert")
                {
                	current.title = "Взрывник";
                	current.titleShort = "Подрывник";
                }
                if (current.title == "Counsellor")
                {
                	current.title = "Советник";
                	current.titleShort = "Советник";
                }
                if (current.title == "Recruiter")
                {
                	current.title = "Рекрутер";
                	current.titleShort = "Рекрутер";
                }
                if (current.title == "Psychiatric patient")
                {
                	current.title = "Пациент дурки";
                	current.titleShort = "Пациент";
                }
                if (current.title == "Drifter")
                {
                	current.title = "Дрифтер";
                	current.titleShort = "Дрифтер";
                }
                if (current.title == "VR designer")
                {
                	current.title = "ВР дизайнер";
                	current.titleShort = "Геймдев";
                }
                if (current.title == "Human computer")
                {
                	current.title = "Человек калькулятор";
                	current.titleShort = "Вычислитель";
                }
                if (current.title == "Architect")
                {
                	current.title = "Архитектор";
                	current.titleShort = "Архитектор";
                }
                if (current.title == "Message carrier")
                {
                	current.title = "Почтальон";
                	current.titleShort = "Почтальон";
                }
                if (current.title == "Sculptor")
                {
                	current.title = "Скульптор";
                	current.titleShort = "Скульптор";
                }
                if (current.title == "Machine collector")
                {
                	current.title = "Коллекционер машин";
                	current.titleShort = "Коллекционер";
                }
                if (current.title == "Sheriff")
                {
                	current.title = "Шериф";
                	current.titleShort = "Шериф";
                }
                if (current.title == "Hiveworld drone")
                {
                	current.title = "Тунеядец";
                	current.titleShort = "Тунеядец";
                }
                if (current.title == "Evangelist")
                {
                	current.title = "Евангелист";
                	current.titleShort = "Евангелист";
                }
                if (current.title == "Herbalist")
                {
                	current.title = "Травник";
                	current.titleShort = "Травник";
                }
                if (current.title == "Coma child")
                {
                	current.title = "Коматозник";
                	current.titleShort = "Коматозник";
                }
                if (current.title == "Civil servant")
                {
                	current.title = "Госслужащий";
                	current.titleShort = "Клерк";
                }
                if (current.title == "Organ farm")
                {
                	current.title = "Суррогат";
                	current.titleShort = "Суррогат";
                }
                if (current.title == "Ascetic priest")
                {
                	current.title = "Аскетичный священник";
                	current.titleShort = "Священник";
                }
                if (current.title == "Escaped convict")
                {
                	current.title = "Убежавший каторжник";
                	current.titleShort = "Беглец";
                }
                if (current.title == "Starship janitor")
                {
                	current.title = "Уборщик на звездолете";
                	current.titleShort = "Уборщик";
                }
                if (current.title == "Gatherer")
                {
                	current.title = "Собиратель";
                	current.titleShort = "Собиратель";
                }
                if (current.title == "Loner")
                {
                	current.title = "Одиночка";
                	current.titleShort = "Одиночка";
                }
                if (current.title == "Con artist")
                {
                	current.title = "Мошенник";
                	current.titleShort = "Мошенник";
                }
                if (current.title == "Abandoned child")
                {
                	current.title = "Оставленый ребенок";
                	current.titleShort = "Отказыш";
                }
                if (current.title == "Reclusive child")
                {
                	current.title = "Нелюдимый ребенок";
                	current.titleShort = "Нелюдим";
                }
                if (current.title == "Herder")
                {
                	current.title = "Гердер";
                	current.titleShort = "Гердер";
                }
                if (current.title == "Scavenger")
                {
                	current.title = "Мусорщик";
                	current.titleShort = "Мусорщик";
                }
                if (current.title == "Cave child")
                {
                	current.title = "Пещерный ребенок";
                	current.titleShort = "Пещеророжденый";
                }
                if (current.title == "Sole survivor")
                {
                	current.title = "Единственный выживший";
                	current.titleShort = "Выживший";
                }
                if (current.title == "Vengeful child")
                {
                	current.title = "Мстительный ребенок";
                	current.titleShort = "Мстительный";
                }
                if (current.title == "Fire tender")
                {
                	current.title = "Храниель огня";
                	current.titleShort = "Храниель огня";
                }
                if (current.title == "Healer")
                {
                	current.title = "Лекарь";
                	current.titleShort = "Лекарь";
                }
                if (current.title == "Digger")
                {
                	current.title = "Копатель";
                	current.titleShort = "Копатель";
                }
                if (current.title == "Muffalo shaman")
                {
                	current.title = "Шаман Маффало";
                	current.titleShort = "Шаман";
                }
                if (current.title == "Lore keeper")
                {
                	current.title = "Хранитель знаний";
                	current.titleShort = "Хранитель";
                }
                if (current.title == "Weaver")
                {
                	current.title = "Ткач";
                	current.titleShort = "Ткач";
                }
                if (current.title == "Cave tender")
                {
                	current.title = "Хранитель пещеры";
                	current.titleShort = "Хранитель";
                }
                if (current.title == "Warrior")
                {
                	current.title = "Воин";
                	current.titleShort = "Воин";
                }
                if (current.title == "")
                {
                	current.title = "";
                	current.titleShort = "";
                }
                
                //Childhood
                if (current.title == "Medieval slave")
                {
                	current.title = "Средневековый раб";
                	current.baseDesc = "NAME grew up pulling carts and digging holes on a medieval world. Simple manual labor is HIS oldest companion - along with the master's lash.\n\nHECAP didn't learn to read until age nine.";
                }
                if (current.title == "Medieval lordling")
                {
                	current.title = "Средневековый наследкий трона";
                	current.baseDesc = "NAME was a minor noble in an old kingdom on a medieval world. HECAP grew up in a manor made of stone, served by bowing lowerclassmen.\n\nSuch a life teaches no technical skills and instils a lifelong aversion to manual labor - but NAME learned early the ways of social manipulation.";
                }
                if (current.title == "Urbworld urchin")
                {
                	current.title = "Городской бука";
                }
                if (current.title == "Vatgrown soldier")
                {
                	current.title = "Солдат из пробирки";
                }
                if (current.title == "Mute")
                {
                	current.title = "Немой";
                }
                if (current.title == "Refugee")
                {
                	current.title = "Беженец";
                }
                if (current.title == "Music lover")
                {
                	current.title = "Меломан";
                }
                if (current.title == "Child star")
                {
                	current.title = "Кинозвезда";
                }
                if (current.title == "Child spy")
                {
                	current.title = "Пионер";
                	current.baseDesc = "Странно... Почему-то всегда и ко всему готов.";
                }
                if (current.title == "Shopkeeper")
                {
                	current.title = "Лавочник";
                }
                if (current.title == "Nurse")
                {
                	current.title = "Медсестра";
                }
                if (current.title == "Convent child")
                {
                	current.title = "Монастырский ребенок";
                }
                if (current.title == "Test subject")
                {
                	current.title = "Подопыдный";
                }
                if (current.title == "Medical assistant")
                {
                	current.title = "Мед ассистент";
                }
                if (current.title == "Cult child")
                {
                	current.title = "Дитя культистов";
                }
                if (current.title == "Wreckage explorer")
                {
                	current.title = "Исследователь обломков";
                }
                if (current.title == "Apocalypse survivor")
                {
                	current.title = "Выживший";
                }
                if (current.title == "Story writer")
                {
                	current.title = "Писатель рассказов";
                }
                if (current.title == "Sailor")
                {
                	current.title = "Моряк";
                }
                if (current.title == "Jailbird")
                {
                	current.title = "Рецидивист";
                }
                if (current.title == "Tunnelworld illuminator")
                {
                	current.title = "Блятьнезнаюкакэтоговноперевести";
                }
                if (current.title == "Tribe child")
                {
                	current.title = "Племенное дитя";
                }
                if (current.title == "")
                {
                	current.title = "";
                }
                if (current.title == "")
                {
                	current.title = "";
                }
                

        }
    }
}
}
