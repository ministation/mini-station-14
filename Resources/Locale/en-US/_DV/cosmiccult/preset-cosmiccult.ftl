<<<<<<< HEAD
## КОСМИЧЕСКИЙ КУЛЬТ, АНТАГОНИСТЫ И РЕЖИМ ИГРЫ

cosmiccult-announcement-sender = ???

cosmiccult-title = Космический Культ
cosmiccult-description = Среди экипажа скрываются культисты.

roles-antag-cosmiccult-name = Космический Культист
roles-antag-cosmiccult-description = Приведи конец всему через скрытность и саботаж, обращая в свою веру тех, кто осмелится противостоять.

cosmiccult-gamemode-title = Космический Культ
cosmiccult-gamemode-description = Сканеры обнаружили аномальный рост Λ-CDM. Дополнительные данные отсутствуют.

cosmiccult-vote-steward-initiator = Неизвестный

cosmiccult-vote-steward-title = Управление Космическим Культом
cosmiccult-vote-steward-briefing =
    Вы — Хранитель Космического Культа!
    Убедитесь, что Монумент установлен в безопасном месте, и организуйте культистов для достижения общей победы.
    Вам запрещено указывать культистам, как использовать или тратить их Энтропию.

cosmiccult-vote-lone-steward-title = Одинокий Культист
cosmiccult-vote-lone-steward-briefing =
    Вы совершенно один. Но ваша миссия не завершена.
    Убедитесь, что Монумент установлен в безопасном месте, и доведите начатое до конца.

cosmiccult-finale-autocall-briefing = Монумент активируется через {$minutesandseconds}! Соберитесь и приготовьтесь к концу.
cosmiccult-finale-ready = Ужасающий свет исходит от Монумента!
cosmiccult-finale-speedup = Зов ускоряется! Энергия пульсирует вокруг...

cosmiccult-finale-degen = Вы чувствуете, как ваше сознание распадается!
cosmiccult-finale-location = Сканеры обнаружили огромный всплеск Λ-CDM в {$location}!
cosmiccult-finale-cancel-begin = Сила вашей воли начинает разрушать ритуал...
cosmiccult-finale-beckon-begin = Шёпот в вашем разуме становится громче...
cosmiccult-finale-beckon-success = Вы призываете финальный занавес.

cosmiccult-monument-powerdown = Монумент жутко замолкает.

## ТЕКСТ ПО ЗАВЕРШЕНИИ РАУНДА

cosmiccult-roundend-cultist-count = {$initialCount ->
    [1] Был {$initialCount} [color=#4cabb3]Космический Культист[/color].
    *[other] Было {$initialCount} [color=#4cabb3]Космических Культистов[/color].
}
cosmiccult-roundend-entropy-count = Культ собрал {$count} Энтропии.
cosmiccult-roundend-cultpop-count = Культисты составляли {$count}% экипажа.
cosmiccult-roundend-monument-stage = {$stage ->
    [1] Увы, Монумент кажется заброшенным.
    [2] Монумент был частично активирован, но до завершения далеко.
    [3] Монумент был завершён.
    *[other] [color=red]Что-то пошло ОЧЕНЬ не так.[/color]
}

cosmiccult-roundend-cultcomplete = [color=#4cabb3]Полная победа Космического Культа![/color]
cosmiccult-roundend-cultmajor = [color=#4cabb3]Крупная победа Космического Культа![/color]
cosmiccult-roundend-cultminor = [color=#4cabb3]Незначительная победа Космического Культа![/color]
cosmiccult-roundend-neutral = [color=yellow]Нейтральный исход![/color]
cosmiccult-roundend-crewminor = [color=green]Незначительная победа экипажа![/color]
cosmiccult-roundend-crewmajor = [color=green]Крупная победа экипажа![/color]
cosmiccult-roundend-crewcomplete = [color=green]Полная победа экипажа![/color]

cosmiccult-summary-cultcomplete = Космические культисты привели конец всему!
cosmiccult-summary-cultmajor = Победа культистов неизбежна.
cosmiccult-summary-cultminor = Монумент был завершён, но не полностью заряжен.
cosmiccult-summary-neutral = Культ доживёт до следующего дня.
cosmiccult-summary-crewminor = Культ остался без хранителя.
cosmiccult-summary-crewmajor = Все космические культисты уничтожены.
cosmiccult-summary-crewcomplete = Каждый культист был обращён обратно!

cosmiccult-elimination-shuttle-call = Согласно сканерам, аномалия Λ-CDM исчезла. Благодарим за бдительность. Аварийный шаттл автоматически вызван на станцию для дезинфекции и допроса. Прибытие через: {$time} {$units}. Если психологическое воздействие аномалии незначительно, шаттл можно отозвать для продолжения смены.
cosmiccult-elimination-announcement = Согласно сканерам, аномалия Λ-CDM исчезла. Благодарим за бдительность. Аварийный шаттл уже в пути. Вернитесь на CentComm для дезинфекции и допроса.

## ИНСТРУКЦИИ

cosmiccult-role-roundstart-fluff =
    Когда вы готовитесь к очередной смене на очередной станции NanoTrasen, ваш разум внезапно наполняется непостижимыми знаниями!
    Откровение, не имеющее аналогов. Конец циклическим, сизифовым страданиям.
    Нежный занавес.

    Всё, что нужно — привести его.

cosmiccult-role-short-briefing =
    Вы — Космический Культист!
    Ваши задачи указаны в меню персонажа.
    Подробнее о вашей роли читайте в руководстве.

cosmiccult-role-conversion-fluff =
    По завершении ритуала ваш разум внезапно наполняется непостижимыми знаниями!
    Откровение, не имеющее аналогов. Конец циклическим, сизифовым страданиям.
    Нежный занавес.

    Всё, что нужно — привести его.

cosmiccult-role-deconverted-fluff =
    Великая пустота окутывает ваш разум. Успокаивающая, но незнакомая пустота...
    Все воспоминания о времени в культе начинают исчезать.

cosmiccult-role-deconverted-briefing =
    Обращён обратно!
    Вы больше не Космический Культист.

cosmiccult-monument-stage1-briefing =
    Монумент был призван.
    Он находится в {$location}!

cosmiccult-monument-stage2-briefing =
    Монумент набирает силу!
    Его влияние проявится в реальности через {$time} секунд.

cosmiccult-monument-stage3-briefing =
    Монумент завершён!
    Его влияние начнёт сливаться с реальностью через {$time} секунд.
    Это финальный этап! Соберите как можно больше Энтропии.

## ЗЛОВЕЩИЕ РАЗРЫВЫ

cosmiccult-rift-inuse = Сейчас это невозможно.
cosmiccult-rift-invaliduser = У вас нет нужных инструментов.
cosmiccult-rift-chaplainoops = Используйте священное писание.
cosmiccult-rift-alreadyempowered = Вы уже наделены силой; разрыв будет потрачен впустую.
cosmiccult-rift-beginabsorb = Разрыв начинает сливаться с вами...
cosmiccult-rift-beginpurge = Ваше освящение начинает очищать зловещий разрыв...

cosmiccult-rift-absorb = {$NAME} поглощает разрыв, и зловещий свет наполняет их тело!
cosmiccult-rift-purge = {$NAME} очищает зловещий разрыв из реальности!

## ИНТЕРФЕЙС / ВСПЛЫВАЮЩИЕ ОКНА

cosmiccult-ui-deconverted-title = Обращён обратно
cosmiccult-ui-converted-title = Обращён
cosmiccult-ui-roundstart-title = Неизвестный

cosmiccult-ui-converted-text-1 =
    Вы были обращены в Космического Культиста.
cosmiccult-ui-converted-text-2 =
    Помогайте культу в его целях, сохраняя его тайну.
    Сотрудничайте с планами других культистов.

cosmiccult-ui-roundstart-text-1 =
    Вы — Космический Культист!
cosmiccult-ui-roundstart-text-2 =
    Помогайте культу в его целях, сохраняя его тайну.
    Слушайте указания хранителя культа.

cosmiccult-ui-deconverted-text-1 =
    Вы больше не Космический Культист.
cosmiccult-ui-deconverted-text-2 =
    Вы потеряли все воспоминания, связанные с культом.
    Если вас обратят снова, они вернутся.

cosmiccult-ui-popup-confirm = Подтвердить

## ЗАДАЧИ / МЕНЮ ПЕРСОНАЖА

objective-issuer-cosmiccult = [bold][color=#cae8e8]Неизвестный[/color][/bold]

objective-cosmiccult-charactermenu = Вы должны привести конец всему. Выполняйте задачи для продвижения культа.
objective-cosmiccult-steward-charactermenu = Вы должны направлять культ к концу всего. Контролируйте и обеспечивайте прогресс культа.

objective-condition-entropy-title = СОБИРАЙТЕ ЭНТРОПИЮ
objective-condition-entropy-desc = Совместно соберите не менее {$count} энтропии у экипажа.
objective-condition-culttier-title = АКТИВИРУЙТЕ МОНУМЕНТ
objective-condition-culttier-desc = Убедитесь, что Монумент достиг полной мощности.
objective-condition-victory-title = ПРИЗЫВАЙТЕ КОНЕЦ
objective-condition-victory-desc = Призовите Неизвестного и возвестите финальный занавес.

## ОБЪЯВЛЕНИЯ В ЧАТЕ

cosmiccult-radio-tier1-progress = Монумент призван на станцию...

cosmiccult-announce-tier2-progress = Ваши чувства окутывает тревожное онемение.
cosmiccult-announce-tier2-warning = Сканеры обнаружили значительный рост Λ-CDM! Вскоре могут появиться разрывы в реальности. Сообщите станционному священнику, если заметите их.

cosmiccult-announce-tier3-progress = Дуги ноосферной энергии пронзают станцию. Конец близок.
cosmiccult-announce-tier3-warning = Критический рост Λ-CDM. Заражённых персонал следует немедленно нейтрализовать.

cosmiccult-announce-finale-warning = Внимание всему экипажу. Аномалия Λ-CDM становится сверхкритичной, приборы отказывают; горизонт перехода ноосферы в реальность НЕИЗБЕЖЕН. Если вы не участвуете в контрпротоколе, немедленно действуйте. Повторяю: Действуйте немедленно или погибнете.

cosmiccult-announce-victory-summon = ЧАСТЬ КОСМИЧЕСКОЙ СИЛЫ ПРИЗВАНА.

## ПРОЧЕЕ

cosmiccult-spire-entropy = Частица энтропии конденсируется на поверхности шпиля.
cosmiccult-entropy-inserted = Вы вливаете {$count} энтропии в Монумент.
cosmiccult-entropy-unavailable = Сейчас это невозможно.
cosmiccult-astral-ascendant = {$name}, Вознесённый
cosmiccult-gear-pickup-rejection = {$ITEM} сопротивляется {CAPITALIZE(THE($TARGET))}!
cosmiccult-gear-pickup = неведомая сила не даёт вам это поднять!
=======
## COSMIC CULT ROUND, ANTAG & GAMEMODE TEXT

cosmiccult-announcement-sender = ???

cosmiccult-title = Cosmic Cult
cosmiccult-description = Cultists lurk amongst the crew.

roles-antag-cosmiccult-name = Cosmic Cultist
roles-antag-cosmiccult-description = Usher in the end of all things through subterfuge and sabotage, brainwashing those who would oppose you.

cosmiccult-gamemode-title = The Cosmic Cult
cosmiccult-gamemode-description = Scanners detect an anomalous increase in Λ-CDM. There is no additional data.

cosmiccult-vote-steward-initiator = The Unknown

cosmiccult-vote-steward-title = Cosmic Cult Stewardship
cosmiccult-vote-steward-briefing =
    You are the Cosmic Cult's Steward!
    Ensure that The Monument is placed in a secure location, and organize the cult to ensure your collective victory.
    You are not permitted to instruct cultists on how to use or spend their Entropy.

cosmiccult-vote-lone-steward-title = The Lone Cultist
cosmiccult-vote-lone-steward-briefing =
    You're completely alone. But your duty is not done.
    Ensure that The Monument is placed in a secure location, and finish what the cult started.

cosmiccult-finale-autocall-briefing = The Monument activates {$minutesandseconds}! Gather yourselves, and prepare for the end.
cosmiccult-finale-ready = A terrifying light surges forth from The Monument!
cosmiccult-finale-speedup = The beckoning quickens! Energy surges through the surroundings...

cosmiccult-finale-degen = You feel yourself unravelling!
cosmiccult-finale-location = Scanners are detecting an enormous Λ-CDM spike {$location}!
cosmiccult-finale-cancel-begin = Your mind's willpower begins to shatter the ritual...
cosmiccult-finale-beckon-begin = The whispers in the back of your mind intensify...
cosmiccult-finale-beckon-success = You beckon for the final curtain call.

cosmiccult-monument-powerdown = The Monument falls eerily silent.

## ROUNDEND TEXT

cosmiccult-roundend-cultist-count = {$initialCount ->
    [1] There was {$initialCount} [color=#4cabb3]Cosmic Cultist[/color].
    *[other] There were {$initialCount} [color=#4cabb3]Cosmic Cultists[/color].
}
cosmiccult-roundend-entropy-count = The cult siphoned {$count} Entropy.
cosmiccult-roundend-cultpop-count = Cultists made up {$count}% of the crew.
cosmiccult-roundend-monument-stage = {$stage ->
    [1] Alas, the Monument seems abandoned.
    [2] The Monument progressed, but completion was out of reach.
    [3] The Monument was completed.
    *[other] [color=red]Something went REALLY wrong.[/color]
}

cosmiccult-roundend-cultcomplete = [color=#4cabb3]Cosmic Cult complete victory![/color]
cosmiccult-roundend-cultmajor = [color=#4cabb3]Cosmic Cult major victory![/color]
cosmiccult-roundend-cultminor = [color=#4cabb3]Cosmic Cult minor victory![/color]
cosmiccult-roundend-neutral = [color=yellow]Neutral ending![/color]
cosmiccult-roundend-crewminor = [color=green]Crew minor victory![/color]
cosmiccult-roundend-crewmajor = [color=green]Crew major victory![/color]
cosmiccult-roundend-crewcomplete = [color=green]Crew complete victory![/color]

cosmiccult-summary-cultcomplete = The cosmic cultists ushered in the end!
cosmiccult-summary-cultmajor = The cosmic cultists' victory will be inevitable.
cosmiccult-summary-cultminor = The Monument was completed, but not fully empowered.
cosmiccult-summary-neutral = The cult will live to see another day.
cosmiccult-summary-crewminor = The cult has been left stewardless.
cosmiccult-summary-crewmajor = All cosmic cultists were eliminated.
cosmiccult-summary-crewcomplete = Every single cosmic cultist was deconverted!

cosmiccult-elimination-shuttle-call = Based on scans from our long-range sensors, the Λ-CDM anomaly has subsided. We thank you for your prudence. An emergency shuttle has been automatically called to the station for decontamination and debriefing procedures. ETA: {$time} {$units}.
cosmiccult-elimination-announcement = Based on scans from our long-range sensors, the Λ-CDM anomaly has subsided. We thank you for your prudence. An emergency shuttle is already inbound. Return to CentComm safely for decontamination and debriefing procedures.


## BRIEFINGS

cosmiccult-role-roundstart-fluff =
    As you ready yourself for yet another shift aboard yet another NanoTrasen station, untold knowledge suddenly floods your mind!
    A revelation beyond compare. An end to cyclic, sisyphean suffering.
    A gentle curtain call.

    All you need do is usher it in.

cosmiccult-role-short-briefing =
    You are a Cosmic Cultist!
    Your objectives are listed in the character menu.
    Read more about your role in the guidebook entry.

cosmiccult-role-conversion-fluff =
    As the invocation completes, untold knowledge suddenly floods your mind!
    A revelation beyond compare. An end to cyclic, sisyphean suffering.
    A gentle curtain call.

    All you need do is usher it in.

cosmiccult-role-deconverted-fluff =
    A great emptiness washes across your mind. A comforting, yet unfamiliar emptiness...
    All the thoughts and memories of your time in the cult begin to fade and blur.

cosmiccult-role-deconverted-briefing =
    Deconverted!
    You are no longer a Cosmic Cultist.

cosmiccult-monument-stage1-briefing =
    The Monument has been beckoned.
    It is located {$location}!

cosmiccult-monument-stage2-briefing =
    The Monument grows in power!
    Its influence will affect realspace in {$time} seconds.

cosmiccult-monument-stage3-briefing =
    The Monument has been completed!
    Its influence will begin to overlap with realspace in {$time} seconds.
    This is the final stretch! Amass as much entropy as you can muster.

## MALIGN RIFTS

cosmiccult-rift-inuse = You can't do this right now.
cosmiccult-rift-invaliduser = You lack to proper tools to deal with this.
cosmiccult-rift-chaplainoops = Wield your holy scripture.
cosmiccult-rift-alreadyempowered = You are already empowered; the rift's power would be wasted.
cosmiccult-rift-beginabsorb = The rift begins to merge with you...
cosmiccult-rift-beginpurge = Your consecration begins purging the malign rift...

cosmiccult-rift-absorb = {$NAME} absorbs the rift, and malign light empowers their body!
cosmiccult-rift-purge = {$NAME} purges the malign rift from reality!



## UI / BASE POPUP

cosmiccult-ui-deconverted-title = Deconverted
cosmiccult-ui-converted-title = Converted
cosmiccult-ui-roundstart-title = The Unknown

cosmiccult-ui-converted-text-1 =
    You have been converted into a Cosmic Cultist.
cosmiccult-ui-converted-text-2 =
    Aid the cult in its goals whilst ensuring its secrecy.
    Cooperate with your fellow cultists' plans.

cosmiccult-ui-roundstart-text-1 =
    You are a Cosmic Cultist!
cosmiccult-ui-roundstart-text-2 =
    Aid the cult in its goals whilst ensuring its secrecy.
    Listen to your cult steward's directions.

cosmiccult-ui-deconverted-text-1 =
    You are no longer a Cosmic Cultist.
cosmiccult-ui-deconverted-text-2 =
    You have lost all memories pertaining to the Cosmic Cult.
    If you are converted back, these memories will return.

cosmiccult-ui-popup-confirm = Confirm



## OBJECTIVES / CHARACTERMENU

objective-issuer-cosmiccult = [bold][color=#cae8e8]The Unknown[/color][/bold]

objective-cosmiccult-charactermenu = You must usher in the end of all things. Complete your tasks to advance the cult's progress.
objective-cosmiccult-steward-charactermenu = You must direct the cult to usher in the end of all things. Oversee and ensure the cult's progress.

objective-condition-entropy-title = SIPHON ENTROPY
objective-condition-entropy-desc = Collectively siphon at least {$count} entropy from the crew.
objective-condition-culttier-title = EMPOWER THE MONUMENT
objective-condition-culttier-desc = Ensure that The Monument is brought to full power.
objective-condition-victory-title = USHER IN THE END
objective-condition-victory-desc = Beckon The Unknown, and herald the final curtain call.

## CHAT ANNOUNCEMENTS

cosmiccult-radio-tier1-progress = The Monument is beckoned unto the station...

cosmiccult-announce-tier2-progress = An unnerving numbness prickles your senses.
cosmiccult-announce-tier2-warning = Scanners detect a notable increase in Λ-CDM! Rifts in realspace may appear shortly. Please alert your station's chaplain if sighted.

cosmiccult-announce-tier3-progress = Arcs of noospheric energy crackle across the station's groaning structure. The end draws near.
cosmiccult-announce-tier3-warning = Critical increase in Λ-CDM detected. Infected personnel are to be subdued or neutralized on sight.

cosmiccult-announce-finale-warning = All station crew. The Λ-CDM anomaly is going supercritical, instruments failing; noospheric-to-real transitional event horizon IMMINENT. If you are not already on counter-protocol, immediately sortie and intervene. Repeat: Intervene immediately or die.

cosmiccult-announce-victory-summon = A FRACTION OF COSMIC POWER IS CALLED FORTH.


## MISC

cosmiccult-spire-entropy = A mote of entropy condenses from the surface of the spire.
cosmiccult-entropy-inserted = You infuse {$count} entropy into The Monument.
cosmiccult-entropy-unavailable = You can't do that right now.
cosmiccult-astral-ascendant = {$name}, Ascendant
cosmiccult-gear-pickup-rejection = The {$ITEM} resists {CAPITALIZE(THE($TARGET))}'s touch!
cosmiccult-gear-pickup = You can feel yourself unravelling while you hold the {$ITEM}!

# Goobstation

cult-alert-recall-shuttle = High concentrations of Λ-CDM of unknown origin detected aboard the station. All anomalous presences must be purged or restrained before evacuation can be authorized.
>>>>>>> goob
