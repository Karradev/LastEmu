using Protocol.IO;

using System;

namespace Protocol.Types
{
	public class GameRolePlayTaxCollectorInformations : GameRolePlayActorInformations
	{
		public const short Id = 148;

		public TaxCollectorStaticInformations identification;

		public byte guildLevel;

		public int taxCollectorAttack;

		public override short TypeId
		{
			get
			{
				return 148;
			}
		}

		public GameRolePlayTaxCollectorInformations()
		{
		}

		public GameRolePlayTaxCollectorInformations(double contextualId, EntityLook look, EntityDispositionInformations disposition, TaxCollectorStaticInformations identification, byte guildLevel, int taxCollectorAttack) : base(contextualId, look, disposition)
		{
			this.identification = identification;
			this.guildLevel = guildLevel;
			this.taxCollectorAttack = taxCollectorAttack;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.identification = ProtocolTypeManager.GetInstance<TaxCollectorStaticInformations>(reader.ReadUShort());
			this.identification.Deserialize(reader);
			this.guildLevel = reader.ReadByte();
			this.taxCollectorAttack = reader.ReadInt();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteShort(this.identification.TypeId);
			this.identification.Serialize(writer);
			writer.WriteByte(this.guildLevel);
			writer.WriteInt(this.taxCollectorAttack);
		}
	}
}