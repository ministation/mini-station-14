vending-machine-restock-invalid-inventory = { CAPITALIZE($this) } не подходит для того, чтобы пополнить { $target }.
vending-machine-restock-needs-panel-open = Техническая панель { CAPITALIZE($target) } должна быть открыта.
<<<<<<< HEAD
vending-machine-restock-start-self = You start restocking { THE($target) }.
vending-machine-restock-start-others = { CAPITALIZE(THE($user)) } starts restocking { THE($target) }.
vending-machine-restock-done-self = You finish restocking { THE($target) }.
vending-machine-restock-done-others = { CAPITALIZE(THE($user)) } finishes restocking { THE($target) }.
vending-machine-restock-start = { $user } начинает пополнять { $target }.
=======
vending-machine-restock-start = { $user } начинает пополнять { $target }.
vending-machine-restock-start-self = Вы начинаете пополнять { $target }.
vending-machine-restock-start-others = { CAPITALIZE($user) } начинает пополнять { $target }.
vending-machine-restock-done-self = Вы закончили полнять { $target }.
vending-machine-restock-done-others = { CAPITALIZE($user) } закончил пополнять { $target }.
>>>>>>> goob
vending-machine-restock-done =
    { $user } { GENDER($user) ->
        [male] закончил
        [female] закончила
        [epicene] закончили
       *[neuter] закончило
    } пополнять { $target }.
