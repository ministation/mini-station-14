<<<<<<< HEAD
ent-SpawnPointGhostBlob = блоб спавнер
    .suffix = DEBUG, спавнер роли призрака
    .desc = { ent-MarkerBase.desc }
ent-MobBlobPod = блоб капля
    .desc = Рядовой боец блоба. Может зомбировать трупы.
ent-MobBlobBlobbernaut = блоббернаут
    .desc = Элитный боец блоба. Обладает огромной силой.
ent-BaseBlob = блоб
    .desc = { "" }
ent-NormalBlobTile = обычная плитка блоба
    .desc = Рядовая часть блоба, требуемая для строительства более совершенных плиток.
ent-CoreBlobTile = ядро блоба
    .desc = Самая важная часть блоба. Уничтожив ядро, погибнут все остальные части.
ent-FactoryBlobTile = фабрика блоба
    .desc = Прозводит Блоб капли и Блоббернаутов со временем.
ent-ResourceBlobTile = ресурсный блоб
    .desc = Производит ресурсы для блоба, тем самым является важной частью для его роста.
ent-NodeBlobTile = узел блоба
    .desc = Мини-версия ядра, которая позволяет ставить вокруг себя специальные блоб-тайлы
ent-StrongBlobTile = крепкая плитка блоба
    .desc = Укреплённая версия обычного тайла. Не пропускает воздух и защищает от механических повреждений.
ent-ReflectiveBlobTile = отражающая плитка блоба
    .desc = Отражает лазеры, но не так хорошо защищает от механических повреждений.
ent-MobObserverBlob = око блоба
    .desc = { "" }
objective-issuer-blob = Блоб
blob-title = Блоб
blob-description = Показатели биобезопасности станции указывают на наличие биологической угрозы 5-го уровня.

ghost-role-information-blobbernaut-name = блоббернаут
ghost-role-information-blobbernaut-description = Вы массивный блоббернаут, защищайте ядро блоба или следуйте его приказам.

ghost-role-information-blobpod-name = блобик
ghost-role-information-blobpod-description = Вы мерзкая сущность, что зомбирует людей. Служите Блобу!
ghost-role-information-blob-name = блоб
ghost-role-information-blob-description = Ты блоб, вы должны захватить эту станцию.

roles-antag-blob-name = Блоб
roles-antag-blob-objective = Поглотите станцию.

guide-entry-blob = Блоб

# Popups
blob-target-normal-blob-invalid = Неподходящий тип блоба.
blob-target-factory-blob-invalid = Неподходящий тип блоба, необходимо выбрать фабрику.
blob-target-node-blob-invalid = Неподходящий тип блоба, необходимо выбрать узел.
blob-target-close-to-resource = Слишком близко к другому ресурсному блобу.
blob-target-nearby-not-node = Поблизости нет узла.
blob-target-close-to-node = Слишком близко к другому узлу.
blob-target-already-produce-blobbernaut = Этот завод уже создал блоббернаута.
blob-cant-split = Вы не можете разделить ядро.
blob-not-have-nodes = У вас нет узлов.
blob-not-enough-resources = Не хватает ресурсов.
blob-help = Только Бог поможет
blob-swap-chem = In development.
blob-mob-attack-blob = Вы не можете атаковать блоба.
blob-get-resource = +{ $point }
blob-spent-resource = -{ $point }
blobberaut-not-on-blob-tile = Вы умираете без тайлов блоба под ногами.
carrier-blob-alert = У вас осталось { $second } секунд до превращения.

blob-mob-zombify-second-start = { $pod } начинает превращать вас в зомби!
blob-mob-zombify-third-start = { $pod } начинает превращать { $target } в зомби!

blob-mob-zombify-second-end = { $pod } превращает вас в зомби!
blob-mob-zombify-third-end = { $pod } превращает { $target } в зомби!

blobberaut-factory-destroy = Ваша фабрика была разрушена.
blob-target-already-connected = К узлу уже привязан блоб данного типа.


# UI
# UI
blob-chem-swap-ui-window-name = Смена химиката
blob-chem-reactivespines-info =
    Реактивные шипы
    Наносит 25 единиц брут урона.
blob-chem-blazingoil-info =
    Пылающее масло
    Наносит 15 урона ожогами и поджигает цели.
    Делает вас уязвимым к воде.
blob-chem-regenerativemateria-info =
    Регенеративная Материя
    Наносит 15 единиц урона ядами.
    Ядро востанавливает здоровье в 10 раз быстрее и дает на 1 очко больше.
blob-chem-explosivelattice-info =
    Взрывная решетка
    Наносит 5 единиц урона ожогами и взрывает цель, нанося 10 брут урона.
    Споры при смерти взрываются.
    Вы получаете имунитет к взрывам.
    Вы получаете на 50% больше урона ожогами и электричеством.
blob-chem-electromagneticweb-info =
    Электромагнитная паутина
    Наносит 20 урона ожогами, 20% шанс вызывать ЭМИ разряд при атаке.
    Любая уничтоженая плитка гарантировано вызовет ЭМИ.
    Вы получаете на 25% больше урона теплом и брутом.

blob-alert-out-off-station = Блоб был удален т.к. был обнаружен вне станции!

# Announcment
blob-alert-recall-shuttle = Эвакуационный шаттл не может быть отправлен на станцию пока существует биологическая угроза 5 уровня.
blob-alert-detect = На станции была обнаружена биологическая угроза 5 уровня, объявлена изоляция станции.
blob-alert-critical = Уровень биологической опасности критический, отправлены коды от ядерной боеголовки, вы должны немедленно взорвать станцию.
blob-alert-critical-NoNukeCode = Уровень биологической опасности критический. Центральное командование приказывает всем оставшимся сотрудникам искать укрытие и ждать ответа.

# Actions
blob-create-factory-action-name = Создать фабрику (80)
blob-create-factory-action-desc = Превращает выбранную клетку в фабрику, которая способна производить различных преспешников блоба, если рядом есть узел или ядро.
blob-create-storage-action-name = Создать хранилище (60)
blob-create-storage-action-desc = Превращает выбранную клетку в хранилище, которое расширяет максимальное количество ресурсов которое может иметь блоб.
blob-create-node-action-name = Создать узел (50)
blob-create-node-action-desc =
    Превращает выбранную клетку в блоб узел.
    Узел активирует эффекты других блобов, лечит и расширяется в пределах своего действия, уничтожая стены и создавая клетки.
blob-produce-blobbernaut-action-name = Создать Блоббернаута (60)
blob-produce-blobbernaut-action-desc = Создает блоббернаута на выбранной фабрике. Каждая фабрика создает его только один раз. Юнит будет получать урон за пределами клеток блоба и восстанавливаться при приближении к узлам.
blob-split-core-action-name = Разделить ядро (400)
blob-split-core-action-desc = Единоразово позволяет превратить выбраный узел в самостоятельное ядро которое будет развиваться независимо от вас.
blob-swap-core-action-name = Переместить ядро (200)
blob-swap-core-action-desc = Производит рокировку вашего ядра с выбраным узлом.
blob-teleport-to-core-action-name = Телепортироваться к ядру
blob-teleport-to-core-action-desc = Телепортирует вашу камеру к ядру.
blob-teleport-to-node-action-name = Телепортироваться к узлу
blob-teleport-to-node-action-desc = Телепортирует вашу камеру к узлу.
blob-create-resource-action-name = Создать ресурсный блоб (60)
blob-create-resource-action-desc = Превращает выбраного нормального блоба в ресурсного блоба который будет производить ресурсы если рядом есть узлы или ядро.
blob-help-action-name = Помощь
blob-help-action-desc = Получите основную информацию об игре за блоба.
blob-swap-chem-action-name = Сменить химикат блоба (70)
blob-swap-chem-action-desc = Позволяет вам сменить текущий химикат на один из 4 выбранных.
blob-carrier-transform-to-blob-action-name = Превратиться в блоба
blob-carrier-transform-to-blob-action-desc = Мгновенно разрывает ваше тело и создает ядро блоба. Учтите что если под вами не будет тайлов - вы исчезнете.
blob-downgrade-action-name = Сбросить клетку блоба
blob-downgrade-action-desc = Превращает выбранную клетку обратно в обычного блоба для установки других видов клеток.
blob-no-using-guns-popup = Большая палка?! БИТЬ!

# Ghost role
blob-carrier-role-name = Носитель блоба
blob-carrier-role-desc = Сущность зараженная "блобом".
blob-carrier-role-rules =
    Вы антагонист. У вас есть 4 минуты перед тем как вы превратитесь в блоба.
    Найдите за это время укромное место для стартовой точки заражения станции, ведь вы очень слабы в первые минуты после создания ядра.
blob-carrier-role-greeting = Вы носитель Блоба. Найдите укромное место на станции и превратитесь в Блоба. Превратите станцию в массу, а ее обитателей в ваших слуг. Все мы Блоб.

# Verbs
blob-pod-verb-zombify = Зомбировать
blob-verb-upgrade-to-strong = Улучшить до сильного блоба
blob-verb-upgrade-to-reflective = Улучшить до отражающего блоба
blob-verb-remove-blob-tile = Убрать блоба
blob-verb-upgrade = Улучшить блоба

# Alerts
blob-resource-alert-name = Ресурсы ядра
blob-resource-alert-desc = Ваши ресурсы которые производят ресурсные блобы и само ядро, требуются для разрастания и особых блобов.
blob-health-alert-name = Здоровье ядра
blob-health-alert-desc = Здоровье вашего ядра. Если оно опустится до 0 вы умрёте.

# Greeting
blob-role-greeting =
    Вы блоб - космический паразит который захватывает станции.
    Ваша цель - стать как можно больше не дав себя уничтожить.
    Используйте горячие клавиши Alt+LMB чтобы улучшать обычные плитки до сильных а сильные до отражающих.
    Позаботьтесь о получении ресурсов с блобов ресурсов.
    Вы практически неуязвимы к физическим повреждениям, но опасайтесь теплового урона.
    Учтите что особые клетки блоба работают только возле узлов или ядра.
blob-zombie-greeting = Вы были заражены спорой блоба которая вас воскресила, теперь вы действуете в интересах блоба.

# End round
blob-round-end-result =
    { $blobCount ->
        [one] Был один блоб.
       *[other] Было { $blobCount } блобов.
    }

blob-user-was-a-blob = [color=gray]{ $user }[/color] был блобом.
blob-user-was-a-blob-named = [color=White]{ $name }[/color] ([color=gray]{ $user }[/color]) был блобом.
blob-was-a-blob-named = [color=White]{ $name }[/color] был блобом.

preset-blob-objective-issuer-blob = [color=#33cc00]Блоб[/color]

blob-user-was-a-blob-with-objectives = [color=gray]{ $user }[/color] был блобом:
blob-user-was-a-blob-with-objectives-named = [color=White]{ $name }[/color] ([color=gray]{ $user }[/color]) был блобом:
blob-was-a-blob-with-objectives-named = [color=White]{ $name }[/color] был блобом:

# Objectivies
objective-condition-blob-capture-title = Захватить станцию
objective-condition-blob-capture-description = Ваша единственная цель - полное и безоговорочное поглощение станции. Вам необходимо владеть как минимум { $count } тайлами блоба.
objective-condition-success = { $condition } | [color={ $markupColor }]Успех![/color]
objective-condition-fail = { $condition } | [color={ $markupColor }]Провал![/color] ({ $progress }%)

ent-MobMouseCancerBlob = мышь
    .desc = Пии! Странно пахнет.
=======
# SPDX-FileCopyrightText: 2024 Fishbait <Fishbait@git.ml>
# SPDX-FileCopyrightText: 2024 fishbait <gnesse@gmail.com>
# SPDX-FileCopyrightText: 2024 lanse12 <cloudability.ez@gmail.com>
# SPDX-FileCopyrightText: 2025 Aiden <28298836+Aidenkrz@users.noreply.github.com>
# SPDX-FileCopyrightText: 2025 Aiden <aiden@djkraz.com>
# SPDX-FileCopyrightText: 2025 GitHubUser53123 <110841413+GitHubUser53123@users.noreply.github.com>
# SPDX-FileCopyrightText: 2025 Ilya246 <57039557+Ilya246@users.noreply.github.com>
# SPDX-FileCopyrightText: 2025 JohnOakman <sremy2012@hotmail.fr>
# SPDX-FileCopyrightText: 2025 Panela <107573283+AgentePanela@users.noreply.github.com>
#
# SPDX-License-Identifier: AGPL-3.0-or-later

objective-issuer-blob = Блоб
ghost-role-information-blobbernaut-name = Блоббернаут
ghost-role-information-blobbernaut-description = Вы — блоббернаут. Вы должны защищать ядро блоба. Используйте + или +e в чате, чтобы говорить в Коллективный разум Блоба.
ghost-role-information-blob-name = Блоб
ghost-role-information-blob-description = Вы — инфекция Блоба. Поглощайте станцию.
roles-antag-blob-name = Блоб
roles-antag-blob-objective = Достигните критической массы.
guide-entry-blob = Блоб
# Popups
blob-target-normal-blob-invalid = Неверный тип блоба, выберите обычный блоб.
blob-target-factory-blob-invalid = Неверный тип блоба, выберите фабричный блоб.
blob-target-node-blob-invalid = Неверный тип блоба, выберите узловой блоб.
blob-target-close-to-resource = Слишком близко к другому ресурсному блобу.
blob-target-nearby-not-node = Поблизости нет узлового или ресурсного блоба.
blob-target-close-to-node = Слишком близко к другому узлу.
blob-target-already-produce-blobbernaut = Эта фабрика уже произвела блоббернаута.
blob-cant-split = Вы не можете разделить ядро блоба.
blob-not-have-nodes = У вас нет узлов.
blob-not-enough-resources = Недостаточно ресурсов.
blob-help = Только Бог может вам помочь.
blob-swap-chem = В разработке.
blob-mob-attack-blob = Вы не можете атаковать блоба.
blob-get-resource = +{ $point }
blob-spent-resource = -{ $point }
blobberaut-not-on-blob-tile = Вы умираете вне плиток блоба.
carrier-blob-alert = У вас осталось { $second } секунд до превращения.
blob-mob-zombify-second-start = { $pod } начинает превращать вас в подконтрольного.
blob-mob-zombify-third-start = { $pod } начинает превращать { $target } в подконтрольного.
blob-mob-zombify-second-end = { $pod } превратил вас в подконтрольного.
blob-mob-zombify-third-end = { $pod } превратил { $target } в подконтрольного.
blobberaut-factory-destroy = фабрика уничтожена
blob-target-already-connected = уже подключено
# UI
blob-chem-swap-ui-window-name = Обмен химикатами
blob-chem-reactivespines-info =
    Реактивные шипы
    Наносят 25 единиц урона ушибами.
blob-chem-blazingoil-info =
    Пылающее масло
    Наносит 15 урона от ожогов и поджигает цель.
    Делает уязвимым к воде.
blob-chem-regenerativemateria-info =
    Регенеративная материя
    Наносит 6 урона ушибами и 15 токсина.
    Ядро блоба восстанавливает здоровье в 10 раз быстрее и генерирует +1 ресурс.
blob-chem-explosivelattice-info =
    Взрывчатая решетка
    Наносит 5 урона от ожогов и взрывает цель, нанося 10 грубого урона.
    Споры взрываются при смерти.
    У вас иммунитет к взрывам.
    Получаете на 50% больше урона от ожогов и электричества.
blob-chem-electromagneticweb-info =
    Электромагнитная паутина
    Наносит 20 урона от ожогов, 20% шанс вызвать импульс ЭМИ при атаке.
    Плитки блоба вызывают ЭМИ при уничтожении.
    Получаете на 25% больше урона ушибами и ожога.
blob-alert-out-off-station = Блоб был удалён, так как находился вне станции!
# Announcment
blob-alert-recall-shuttle = Аварийный шаттл не может быть вызван, пока на станции присутствует биологическая угроза 5-го уровня.
blob-alert-detect = Подтверждена вспышка биологической угрозы 5-го уровня на станции. Все сотрудники обязаны сдерживать угрозу.
blob-alert-critical = Критический уровень биологической угрозы. На станцию отправлены коды ядерной аутентификации. Центральное командование приказывает всем оставшимся членам экипажа активировать механизм самоуничтожения.
blob-alert-critical-NoNukeCode = Критический уровень биологической угрозы. Центральное командование приказывает оставшимся членам экипажа укрыться и ожидать помощь.
# Actions
blob-teleport-to-node-action-name = Телепорт к узлу (0)
blob-teleport-to-node-action-desc = Телепортирует вас к случайному узловому блобу.
blob-help-action-name = Помощь
blob-help-action-desc = Получить базовую информацию об игре за блоба.
# Ghost role
blob-carrier-role-name = Носитель блоба
blob-carrier-role-desc = Существо, инфицированное блобом.
blob-carrier-role-rules =
    Вы — антагонист. У вас есть 10 минут до превращения в блоба.
    Используйте это время, чтобы найти безопасное место на станции. Учтите, что после превращения вы будете очень слабы.
blob-carrier-role-greeting = Вы — носитель блоба. Найдите укромное место на станции и превратитесь в блоба. Превратите станцию в массу, а её обитателей в своих слуг. Мы все — блобы.
# Verbs
blob-pod-verb-zombify = Подчинить
blob-verb-upgrade-to-strong = Улучшить до усиленного блоба
blob-verb-upgrade-to-reflective = Улучшить до отражающего блоба
blob-verb-remove-blob-tile = Убрать блоб
# Alerts
blob-resource-alert-name = Ресурсы ядра
blob-resource-alert-desc = Ваши ресурсы, производимые ядром и ресурсными блобами. Используйте их для расширения и создания специализированных блобов.
blob-health-alert-name = Здоровье ядра
blob-health-alert-desc = Здоровье вашего ядра. Вы умрёте, если оно упадёт до нуля.
# Greeting
blob-role-greeting =
    Вы — блоб, паразитическое космическое существо, способное уничтожать целые станции.
        Ваша цель — выжить и вырасти как можно больше.
        Вы почти неуязвимы к физическому урону, но огонь всё ещё может навредить вам.
        Используйте Alt+ЛКМ, чтобы улучшать обычные плитки блоба в усиленные, а усиленные — в отражающие.
        Обязательно размещайте ресурсные блобы для генерации ресурсов.
        Помните, что ресурсные блобы и фабрики работают только рядом с узловыми блобами или ядрами.
        Используйте + или +e в чате, чтобы общаться со своими подчинёнными при помощи коллективного разума Блоба.
blob-zombie-greeting = Вы были заражены и воскрешены спорами блоба. Теперь вам нужно помочь блобу захватить станцию. Используйте +e в чате для общения через коллективный разум Блоба.
# End round
blob-round-end-result =
    { $blobCount ->
        [one] Было одно заражение блобом.
       *[other] Было { $blobCount } заражений блобами.
    }
blob-user-was-a-blob = [color=gray]{ $user }[/color] был(а) блобом.
blob-user-was-a-blob-named = [color=White]{ $name }[/color] ([color=gray]{ $user }[/color]) был(а) блобом.
blob-was-a-blob-named = [color=White]{ $name }[/color] был(а) блобом.
preset-blob-objective-issuer-blob = [color=#33cc00]Блоб[/color]
blob-user-was-a-blob-with-objectives = [color=gray]{ $user }[/color] был(а) блобом со следующими целями:
blob-user-was-a-blob-with-objectives-named = [color=White]{ $name }[/color] ([color=gray]{ $user }[/color]) был(а) блобом со следующими целями:
blob-was-a-blob-with-objectives-named = [color=White]{ $name }[/color] был(а) блобом со следующими целями:
# Objectivies
objective-condition-blob-capture-title = Захватить станцию
objective-condition-blob-capture-description = Ваша единственная цель — захватить всю станцию. Для этого у вас должно быть не менее { $count } плиток блоба.
objective-condition-success = { $condition } | [color={ $markupColor }]Успех![/color]
objective-condition-fail = { $condition } | [color={ $markupColor }]Провал![/color] ({ $progress }%)

# Admin Verbs

admin-verb-make-blob = Сделать цель носителем блоба.
admin-verb-text-make-blob = Сделать носителем блоба
# Language
language-Blob-name = Блоб
chat-language-Blob-name = Блоб
language-Blob-description = Блиб боб! Блоб блоб!
>>>>>>> goob
