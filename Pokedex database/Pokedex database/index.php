<!DOCTYPE html>

<html>
    <head>
        <title>Adicionar à Pokedex</title>

        <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
        <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js" integrity="sha384-UO2eT0CpHqdSJQ6hJty5KVphtPhzWj9WO1clHTMGa3JDZwrnQq4sF86dIHNDz0W1" crossorigin="anonymous"></script>
        <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js" integrity="sha384-JjSmVgyd0p3pXB1rRibZUAYoIIy6OrQ6VrjIEaFf/nJGzIxFDsf4x0xIM+B07jRM" crossorigin="anonymous"></script>

        <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous">
    </head>
    <body>
        <?php require_once 'process.php'; ?>
        <div class="row justify-content-center">
        <form action="process.php" method="POST">
            <div class="form-group">
            <label>Number</label>
            <input type="text" name="id" class="form-control" value="Ex:. 001" >
            </div>
            <div class="form-group">
            <label>Name</label>
            <input type="text" name="name" class="form-control" value="Ex:. Bulbasaur" >
            </div>
            <div class="form-group">
            <label>Catch</label>
            <input type="text" name="catch" class="form-control" value="" >
            </div>
            <div class="form-group">
            <label>Image</label>
            <input type="text" name="img" class="form-control" value="" >
            </div>
            <div class="form-group">
            <label>1st Type</label>
            <input type="text" name="type1" class="form-control" value="Ex:. Grass" >
            </div>
            <div class="form-group">
            <label>2st Type</label>
            <input type="text" name="type2" class="form-control" value="Ex:. Poison" >
            </div>
            <div class="form-group">
            <label>Bio Categorie</label>
            <input type="text" name="categorie" class="form-control" value="SEED POKÉMON" >
            </div>
            <div class="form-group">
            <label>Bio</label>
            <input type="text" name="bio" class="form-control" value="The Pokémon Bio" >
            </div>
            <div class="form-group">
            <button type="submit" name="add" class="btn btn-primary">Add</button>
            </div>
        </form>
        </div>


    </body>
</html>
