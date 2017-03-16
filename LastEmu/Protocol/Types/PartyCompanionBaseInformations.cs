using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class PartyCompanionBaseInformations
	{
		public const short Id = 453;

		public sbyte indexId;

		public sbyte companionGenericId;

		public EntityLook entityLook;

		public virtual short TypeId
		{
			get
			{
				return 453;
			}
		}

		public PartyCompanionBaseInformations()
		{
		}

		public PartyCompanionBaseInformations(sbyte indexId, sbyte companionGenericId, EntityLook entityLook)
		{
			this.indexId = indexId;
			this.companionGenericId = companionGenericId;
			this.entityLook = entityLook;
		}

		public virtual void Deserialize(IDataReader reader)
		{
			this.indexId = reader.ReadSByte();
			this.companionGenericId = reader.ReadSByte();
			this.entityLook = new EntityLook();
			this.entityLook.Deserialize(reader);
		}

		public virtual void Serialize(IDataWriter writer)
		{
			writer.WriteSByte(this.indexId);
			writer.WriteSByte(this.companionGenericId);
			this.entityLook.Serialize(writer);
		}
	}
}