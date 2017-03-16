using Protocol.IO;

using System;

namespace Protocol.Types
{
	public class GameContextActorInformations
	{
		public const short Id = 150;

		public double contextualId;

		public EntityLook look;

		public EntityDispositionInformations disposition;

		public virtual short TypeId
		{
			get
			{
				return 150;
			}
		}

		public GameContextActorInformations()
		{
		}

		public GameContextActorInformations(double contextualId, EntityLook look, EntityDispositionInformations disposition)
		{
			this.contextualId = contextualId;
			this.look = look;
			this.disposition = disposition;
		}

		public virtual void Deserialize(IDataReader reader)
		{
			this.contextualId = reader.ReadDouble();
			this.look = new EntityLook();
			this.look.Deserialize(reader);
			this.disposition = ProtocolTypeManager.GetInstance<EntityDispositionInformations>(reader.ReadUShort());
			this.disposition.Deserialize(reader);
		}

		public virtual void Serialize(IDataWriter writer)
		{
			writer.WriteDouble(this.contextualId);
			this.look.Serialize(writer);
			writer.WriteShort(this.disposition.TypeId);
			this.disposition.Serialize(writer);
		}
	}
}