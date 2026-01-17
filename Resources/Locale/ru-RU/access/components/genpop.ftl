<<<<<<< HEAD
genpop-prisoner-id-expire = You have served your sentence! You may now exit prison through the turnstiles and collect your belongings.
genpop-prisoner-id-popup-not-served = Sentence not yet served!
genpop-prisoner-id-crime-default = [Redacted]
genpop-prisoner-id-examine-wait =
    You have served { $minutes } { $minutes ->
        [1] minute
       *[other] minutes
    } { $seconds } { $seconds ->
        [1] second
       *[other] seconds
    } of your { $sentence } minute sentence for { $crime }.
genpop-prisoner-id-examine-wait-perm = You are serving a permanent sentence for { $crime }.
genpop-prisoner-id-examine-served = You have served your sentence for { $crime }.
genpop-locker-name-default = prisoner closet
genpop-locker-desc-default = It's a secure locker for an inmate's personal belongings during their time in prison.
genpop-locker-name-used = prisoner closet ({ $name })
genpop-locker-desc-used = It's a secure locker for an inmate's personal belongings during their time in prison. It contains the personal effects of { $name }.
genpop-locker-ui-label-name = [bold]Convict Name:[/bold]
genpop-locker-ui-label-sentence = [bold]Sentence length in minutes:[/bold] [color=gray](0 for perma)[/color]
genpop-locker-ui-label-crime = [bold]Crime:[/bold]
genpop-locket-ui-button-done = Done
genpop-locker-action-end-early = End Sentence Early
genpop-locker-action-clear-id = Clear ID
genpop-locker-action-reset-sentence = Reset Sentence ({ NATURALFIXED($percent, 0) }% served)
=======
genpop-prisoner-id-expire = Вы отбыли наказание! Теперь вы можете выйти из тюрьмы через турникеты и забрать свои вещи.
genpop-prisoner-id-popup-not-served = Наказание ещё не отбыто!
genpop-prisoner-id-crime-default = [Редактировать]
genpop-prisoner-id-examine-wait =
    Вы отбыли { $minutes } { $minutes ->
        [1] минуту
        [few] минуты
       *[other] минут
    } { $seconds } { $seconds ->
        [1] секунду
        [few] секунды
       *[other] секунд
    } из { $sentence } { $sentence ->
        [1] минуты
       *[other] минут
    } вашего приговора за "{ $crime }".
genpop-prisoner-id-examine-wait-perm = Вы отбываете бессрочное наказание за "{ $crime }".
genpop-prisoner-id-examine-served = Вы отбыли своё наказание за "{ $crime }".
genpop-locker-name-default = шкаф заключённого
genpop-locker-desc-default = Это защищённый шкафчик для персональных вещей заключённого во время его пребывания в тюрьме.
genpop-locker-name-used = prisoner closet ({ $name })
genpop-locker-desc-used = Это защищённый шкафчик для персональных вещей заключённого во время его пребывания в тюрьме. Содержит личные вещи { $name }.
genpop-locker-ui-label-name = [bold]Имя осуждённого:[/bold]
genpop-locker-ui-label-sentence = [bold]Продолжительность наказания в минутах:[/bold] [color=gray](0 для бессрочного)[/color]
genpop-locker-ui-label-crime = [bold]Преступление:[/bold]
genpop-locket-ui-button-done = Готово
genpop-locker-action-end-early = Досрочное освобождение от наказания
genpop-locker-action-clear-id = Очистить ID
genpop-locker-action-reset-sentence = Сброс времени приговора ({ NATURALFIXED($percent, 0) }% отбыто)
>>>>>>> goob
