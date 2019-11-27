namespace Solution.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class jihed : DbMigration
    {
        public override void Up()
        {
            CreateTable(
              "categorie",
              c => new
              {
                  id = c.Int(nullable: false, identity: true),
              })
              .PrimaryKey(t => t.id);

          
            CreateTable(
                "commentaire",
                c => new
                {
                    id = c.Int(nullable: false),
                    type_com = c.String(nullable: false, maxLength: 31, unicode: false),
                    comment = c.String(maxLength: 255, unicode: false),
                    projet_id = c.Int(),
                    evaluation_id = c.Int(),
                    timesheet_id = c.Int(),
                })
                .PrimaryKey(t => t.id);

            CreateTable(
                "competence",
                c => new
                {
                    id = c.Int(nullable: false, identity: true),
                    description = c.String(maxLength: 255, unicode: false),
                    nom = c.String(maxLength: 255, unicode: false),
                })
                .PrimaryKey(t => t.id);

           

            CreateTable(
                "cours",
                c => new
                {
                    id = c.Int(nullable: false, identity: true),
                })
                .PrimaryKey(t => t.id);

            CreateTable(
                "coursformateur",
                c => new
                {
                    id = c.Int(nullable: false, identity: true),
                })
                .PrimaryKey(t => t.id);

            CreateTable(
                "demandemission",
                c => new
                {
                    id = c.Int(nullable: false, identity: true),
                    etat = c.Boolean(storeType: "bit"),
                    employees_id = c.Int(),
                    missions_id = c.Int(),
                })
                .PrimaryKey(t => t.id);

            CreateTable(
                "empcomp",
                c => new
                {
                    id = c.Int(nullable: false, identity: true),
                    competenceId = c.Int(nullable: false),
                    employeeId = c.Int(nullable: false),
                    score = c.Single(nullable: false),
                })
                .PrimaryKey(t => t.id);

        

            CreateTable(
                "evaluationfile",
                c => new
                {
                    id = c.Int(nullable: false),
                    noteEmploye = c.Int(nullable: false),
                    noteManager = c.Int(nullable: false),
                    objec = c.String(maxLength: 255, unicode: false),
                    result = c.String(maxLength: 255, unicode: false),
                })
                .PrimaryKey(t => t.id);


            CreateTable(
                "examen",
                c => new
                {
                    id = c.Int(nullable: false, identity: true),
                    catExam = c.String(maxLength: 255, unicode: false),
                    date = c.DateTime(storeType: "date"),
                    formation = c.String(maxLength: 255, unicode: false),
                    idFor = c.Int(nullable: false),
                    idPar = c.Int(nullable: false),
                    nomExamen = c.String(maxLength: 255, unicode: false),
                    note = c.Int(),
                    participant = c.String(maxLength: 255, unicode: false),
                    typeExam = c.String(maxLength: 255, unicode: false),
                })
                .PrimaryKey(t => t.id);

            CreateTable(
                "formation",
                c => new
                {
                    id = c.Int(nullable: false, identity: true),
                    dateDebut = c.DateTime(precision: 0),
                    dateFin = c.DateTime(precision: 0),
                    nom = c.String(maxLength: 255, unicode: false),
                    refnamepar = c.String(maxLength: 255, unicode: false),
                    type = c.String(maxLength: 255, unicode: false),
                    participant_id = c.Int(),
                })
                .PrimaryKey(t => t.id);

            CreateTable(
                "mission",
                c => new
                {
                    id = c.Int(nullable: false),
                    Mission = c.String(nullable: false, maxLength: 31, unicode: false),
                    description = c.String(maxLength: 255, unicode: false),
                    duree = c.DateTime(storeType: "date"),
                    emp = c.Binary(storeType: "tinyblob"),
                    etat = c.Boolean(storeType: "bit"),
                    libelle = c.String(maxLength: 255, unicode: false),
                })
                .PrimaryKey(t => t.id);

            CreateTable(
                "objectifs",
                c => new
                {
                    id = c.Int(nullable: false),
                    obj1 = c.String(maxLength: 255, unicode: false),
                    obj2 = c.String(maxLength: 255, unicode: false),
                    obj3 = c.String(maxLength: 255, unicode: false),
                    filee_id = c.Int(),
                })
                .PrimaryKey(t => t.id);

            CreateTable(
                "participant",
                c => new
                {
                    id = c.Int(nullable: false, identity: true),
                    Refname = c.String(maxLength: 255, unicode: false),
                    adresse = c.String(maxLength: 255, unicode: false),
                    cin = c.Int(nullable: false),
                    email = c.String(maxLength: 255, unicode: false),
                    idEmp = c.Int(nullable: false),
                    nom = c.String(maxLength: 255, unicode: false),
                    sexe = c.String(maxLength: 255, unicode: false),
                    type = c.String(maxLength: 255, unicode: false),
                })
                .PrimaryKey(t => t.id);


          

            CreateTable(
                "question",
                c => new
                {
                    id = c.Int(nullable: false, identity: true),
                })
                .PrimaryKey(t => t.id);

            CreateTable(
                "quiz",
                c => new
                {
                    id = c.Int(nullable: false, identity: true),
                })
                .PrimaryKey(t => t.id);

            CreateTable(
                "reclamations",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Objet = c.String(unicode: false),
                    Description = c.String(unicode: false),
                    DateReclamation = c.DateTime(nullable: false, precision: 0),
                    DateTraitement = c.DateTime(precision: 0),
                    Etat = c.Boolean(nullable: false),
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "reponse",
                c => new
                {
                    id = c.Int(nullable: false, identity: true),
                })
                .PrimaryKey(t => t.id);

            


            CreateTable(
                "typeformation",
                c => new
                {
                    id = c.Int(nullable: false, identity: true),
                    type = c.String(maxLength: 255, unicode: false),
                })
                .PrimaryKey(t => t.id);
        }
        
        public override void Down()
        {
        }
    }
}
