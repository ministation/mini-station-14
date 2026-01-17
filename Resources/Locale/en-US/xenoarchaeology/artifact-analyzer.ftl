<<<<<<< HEAD
# Консоль анализа артефактов
analysis-console-menu-title = Анализатор артефактов Mark 3
analysis-console-server-list-button = Сервер
analysis-console-extract-button = Извлечь очки
=======
# SPDX-FileCopyrightText: 2023 Guillaume E <262623+quatre@users.noreply.github.com>
# SPDX-FileCopyrightText: 2023 Nemanja <98561806+EmoGarbage404@users.noreply.github.com>
# SPDX-FileCopyrightText: 2023 Vasilis <vascreeper@yahoo.com>
# SPDX-FileCopyrightText: 2023 Vasilis <vasilis@pikachu.systems>
# SPDX-FileCopyrightText: 2023 deltanedas <39013340+deltanedas@users.noreply.github.com>
# SPDX-FileCopyrightText: 2024 Hannah Giovanna Dawson <karakkaraz@gmail.com>
# SPDX-FileCopyrightText: 2024 eoineoineoin <github@eoinrul.es>
# SPDX-FileCopyrightText: 2025 Aiden <28298836+Aidenkrz@users.noreply.github.com>
# SPDX-FileCopyrightText: 2025 Aiden <aiden@djkraz.com>
#
# SPDX-License-Identifier: AGPL-3.0-or-later

analysis-console-menu-title = Broad-Spectrum Mark 3 Analysis Console
analysis-console-server-list-button = Server
analysis-console-extract-button = Extract points
>>>>>>> goob

analysis-console-info-no-scanner = Анализатор не подключен! Подключите с помощью мультитула.
analysis-console-info-no-artifact = Артефакт не обнаружен! Поместите артефакт на платформу для сканирования.
analysis-console-info-ready = Системы готовы. Можно сканировать.

analysis-console-no-node = Выберите узел для просмотра
analysis-console-info-id = [font="Monospace" size=11]Идентификатор:[/font]
analysis-console-info-id-value = [font="Monospace" size=11][color=yellow]{$id}[/color][/font]
analysis-console-info-class = [font="Monospace" size=11]Класс:[/font]
analysis-console-info-class-value = [font="Monospace" size=11]{$class}[/font]
analysis-console-info-locked = [font="Monospace" size=11]Статус:[/font]
analysis-console-info-locked-value = [font="Monospace" size=11][color={ $state ->
    [0] red]Заблокирована
    [1] lime]Разблокирована
    *[2] plum]Активна
}[/color][/font]
analysis-console-info-durability = [font="Monospace" size=11]Прочность:[/font]
analysis-console-info-durability-value = [font="Monospace" size=11][color={$color}]{$current}/{$max}[/color][/font]
analysis-console-info-effect = [font="Monospace" size=11]Эффект:[/font]
analysis-console-info-effect-value = [font="Monospace" size=11][color=gray]{ $state ->
    [true] {$info}
    *[false] Разблокируйте узлы для получения информации
}[/color][/font]
analysis-console-info-trigger = [font="Monospace" size=11]Триггеры:[/font]
analysis-console-info-triggered-value = [font="Monospace" size=11][color=gray]{$triggers}[/color][/font]
analysis-console-info-scanner = Сканирование...
analysis-console-info-scanner-paused = Пауза.
analysis-console-progress-text = {$seconds ->
    [one] T-{$seconds} секунда
    [few] T-{$seconds} секунды
    *[other] T-{$seconds} секунд
}

analysis-console-extract-value = [font="Monospace" size=11][color=orange]Нода {$id} (+{$value})[/color][/font]
analysis-console-extract-none = [font="Monospace" size=11][color=orange] Нет разблокированных узел с доступными очками [/color][/font]
analysis-console-extract-sum = [font="Monospace" size=11][color=orange]Всего исследований: {$value}[/color][/font]

analyzer-artifact-extract-popup = На поверхности артефакта мерцает энергия!
