using LeaveTracker.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveTracker.Infrastructure.Configuration;

public class IllnessConfiguration : IEntityTypeConfiguration<Illness>
{
    public void Configure(EntityTypeBuilder<Illness> builder)
    {
        builder.Property(illness => illness.Name).HasColumnType("VARCHAR(100)").IsRequired();
        builder.Property(illness => illness.CreatedAt).HasColumnType("DATETIME").IsRequired().HasDefaultValueSql("GETUTCDATE()").IsRequired();
        builder.Property(illness => illness.CreatedBy).HasColumnType("VARCHAR(30)").IsRequired();
        builder.Property(illness => illness.UpdatedAt).HasColumnType("DATETIME").IsRequired().HasDefaultValueSql("GETUTCDATE()").IsRequired();
        builder.Property(illness => illness.UpdatedBy).HasColumnType("VARCHAR(30)").IsRequired();
        builder.Property(illness => illness.IsActive).HasColumnType("BIT").IsRequired();

        builder.HasData
        (
            new Illness
            {
                Id = 1,
                Name = "Abscess",
            },
            new Illness
            {
                Id = 2,
                Name = "Acute Soft Tissue Injury",
            },
            new Illness
            {
                Id = 3,
                Name = "Adrenal Malfunction",
            },
            new Illness
            {
                Id = 4,
                Name = "Alcohol & Drug Abuse",
            },
            new Illness
            {
                Id = 5,
                Name = "Allergies",
            },
            new Illness
            {
                Id = 6,
                Name = "Anaemia",
            },
            new Illness
            {
                Id = 7,
                Name = "Angina",
            },
            new Illness
            {
                Id = 8,
                Name = "Ankylosing Spondylitis",
            },
            new Illness
            {
                Id = 9,
                Name = "Anxiety",
            },
            new Illness
            {
                Id = 10,
                Name = "Appendicitis",
            },
            new Illness
            {
                Id = 11,
                Name = "Arrhythmia",
            },
            new Illness
            {
                Id = 12,
                Name = "Arthritis",
            },
            new Illness
            {
                Id = 13,
                Name = "Asthma",
            },
            new Illness
            {
                Id = 14,
                Name = "Ataxia",
            },
            new Illness
            {
                Id = 15,
                Name = "Back Pain",
            },
            new Illness
            {
                Id = 16,
                Name = "Bells Palsy",
            },
            new Illness
            {
                Id = 17,
                Name = "Bereavement",
            },
            new Illness
            {
                Id = 18,
                Name = "Biopsy",
            },
            new Illness
            {
                Id = 19,
                Name = "Bladder Dysfunction",
            },
            new Illness
            {
                Id = 20,
                Name = "Blackouts",
            },
            new Illness
            {
                Id = 21,
                Name = "Blood Dyscriasis",
            },
            new Illness
            {
                Id = 22,
                Name = "Blood Investigations",
            },
            new Illness
            {
                Id = 23,
                Name = "Bowel Disease",
            },
            new Illness
            {
                Id = 24,
                Name = "Bowel Obstruction",
            },
            new Illness
            {
                Id = 25,
                Name = "Breast Lump",
            },
            new Illness
            {
                Id = 26,
                Name = "Bronchitis",
            },
            new Illness
            {
                Id = 27,
                Name = "Burns",
            },
            new Illness
            {
                Id = 28,
                Name = "Cancer",
            },
            new Illness
            {
                Id = 29,
                Name = "Cardiac Investigations",
            },
            new Illness
            {
                Id = 30,
                Name = "Cellulitis",
            },
            new Illness
            {
                Id = 31,
                Name = "Chemotherapy",
            },
            new Illness
            {
                Id = 32,
                Name = "Chicken Pox",
            },
            new Illness
            {
                Id = 33,
                Name = "Chronic Fatigue Syndrome",
            },
            new Illness
            {
                Id = 34,
                Name = "Chronic Soft Tissue Conditions",
            },
            new Illness
            {
                Id = 35,
                Name = "Clotting Disorders",
            },
            new Illness
            {
                Id = 36,
                Name = "Cold",
            },
            new Illness
            {
                Id = 37,
                Name = "Concussion",
            },
            new Illness
            {
                Id = 38,
                Name = "Congenital Conditions",
            },
            new Illness
            {
                Id = 39,
                Name = "Covid",
            },
            new Illness
            {
                Id = 40,
                Name = "Crohns Disease",
            },
            new Illness
            {
                Id = 41,
                Name = "Debility",
            },
            new Illness
            {
                Id = 42,
                Name = "Dental Treatments",
            },
            new Illness
            {
                Id = 43,
                Name = "Depression",
            },
            new Illness
            {
                Id = 44,
                Name = "Diabetes",
            },
            new Illness
            {
                Id = 45,
                Name = "Diarrhoea",
            },
            new Illness
            {
                Id = 46,
                Name = "Dislocations",
            },
            new Illness
            {
                Id = 47,
                Name = "Diverticulitis",
            },
            new Illness
            {
                Id = 48,
                Name = "Dyspepsia",
            },
            new Illness
            {
                Id = 49,
                Name = "Eating Disorder",
            },
            new Illness
            {
                Id = 50,
                Name = "Epilepsy",
            },
            new Illness
            {
                Id = 51,
                Name = "Exhaustion",
            },
            new Illness
            {
                Id = 52,
                Name = "Eye Problems",
            },
            new Illness
            {
                Id = 53,
                Name = "Fainting",
            },
            new Illness
            {
                Id = 54,
                Name = "Fatigue",
            },
            new Illness
            {
                Id = 55,
                Name = "Fibroids",
            },
            new Illness
            {
                Id = 56,
                Name = "Fibromyalgia",
            },
            new Illness
            {
                Id = 57,
                Name = "Food Poisoning",
            },
            new Illness
            {
                Id = 58,
                Name = "Fractures",
            },
            new Illness
            {
                Id = 59,
                Name = "Glandular Fever",
            },
            new Illness
            {
                Id = 60,
                Name = "Gout",
            },
            new Illness
            {
                Id = 61,
                Name = "Hayfever",
            },
            new Illness
            {
                Id = 62,
                Name = "Headache",
            },
            new Illness
            {
                Id = 63,
                Name = "Hearing Loss",
            },
            new Illness
            {
                Id = 64,
                Name = "Hepatitis",
            },
            new Illness
            {
                Id = 65,
                Name = "HIV/AIDS",
            },
            new Illness
            {
                Id = 66,
                Name = "Hodgkins Disease",
            },
            new Illness
            {
                Id = 67,
                Name = "Hypertension",
            },
            new Illness
            {
                Id = 68,
                Name = "Hypotension",
            },
            new Illness
            {
                Id = 69,
                Name = "Impetigo",
            },
            new Illness
            {
                Id = 70,
                Name = "Influenza",
            },
            new Illness
            {
                Id = 71,
                Name = "Investigations",
            },
            new Illness
            {
                Id = 72,
                Name = "Kidney Stones",
            },
            new Illness
            {
                Id = 73,
                Name = "Labyrinthitis",
            },
            new Illness
            {
                Id = 74,
                Name = "Measles",
            },
            new Illness
            {
                Id = 75,
                Name = "Meningitis",
            },
            new Illness
            {
                Id = 76,
                Name = "Menopause Symptoms",
            },
            new Illness
            {
                Id = 77,
                Name = "Migraine",
            },
            new Illness
            {
                Id = 78,
                Name = "Myocardial Infarction",
            },
            new Illness
            {
                Id = 79,
                Name = "Pharyngitis",
            },
            new Illness
            {
                Id = 80,
                Name = "Pulmonary Embolism",
            },
            new Illness
            {
                Id = 81,
                Name = "Quarantine",
            },
            new Illness
            {
                Id = 82,
                Name = "Radiotherapy",
            },
            new Illness
            {
                Id = 83,
                Name = "Renal Failure",
            },
            new Illness
            {
                Id = 84,
                Name = "Pleurisy",
            },
            new Illness
            {
                Id = 85,
                Name = "Pneumonia",
            },
            new Illness
            {
                Id = 86,
                Name = "Pneumothorax",
            },
            new Illness
            {
                Id = 87,
                Name = "Poisoning",
            },
            new Illness
            {
                Id = 88,
                Name = "Repetitive Strain Disorder",
            },
            new Illness
            {
                Id = 89,
                Name = "Seizures",
            },
            new Illness
            {
                Id = 90,
                Name = "Sexually Transmitted Diseases",
            },
            new Illness
            {
                Id = 91,
                Name = "Sinusitis",
            },
            new Illness
            {
                Id = 92,
                Name = "Sleep Disturbance",
            },
            new Illness
            {
                Id = 93,
                Name = "Stress",
            },
            new Illness
            {
                Id = 94,
                Name = "Sunburn",
            },
            new Illness
            {
                Id = 95,
                Name = "Surgery",
            },
            new Illness
            {
                Id = 96,
                Name = "Tendonitis",
            },
            new Illness
            {
                Id = 97,
                Name = "Testicular Abnormality",
            },
            new Illness
            {
                Id = 98,
                Name = "Tenosynovitis",
            },
            new Illness
            {
                Id = 99,
                Name = "Tinnitus",
            },
            new Illness
            {
                Id = 100,
                Name = "Tonsillitis",
            },
            new Illness
            {
                Id = 101,
                Name = "Tracheitis",
            },
            new Illness
            {
                Id = 102,
                Name = "Urinary Tract Infections",
            },
            new Illness
            {
                Id = 103,
                Name = "Vertigo",
            },
            new Illness
            {
                Id = 104,
                Name = "Vestibulitis",
            },
            new Illness
            {
                Id = 105,
                Name = "Viral Infections",
            },
            new Illness
            {
                Id = 106,
                Name = "Thyroid Malfunction",
            },
            new Illness
            {
                Id = 107,
                Name = "Ulcer",
            },
            new Illness
            {
                Id = 108,
                Name = "Ulcerative Colitis",
            },
            new Illness
            {
                Id = 109,
                Name = "Urticaria",
            },
            new Illness
            {
                Id = 110,
                Name = "Vomiting",
            }
        );
    }
}
