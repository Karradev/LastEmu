using Protocol.IO;
using System;

namespace Protocol.Messages
{
	public class ObjectUseOnCharacterMessage : ObjectUseMessage
	{
		public const uint Id = 3003;

		public double characterId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)3003;
			}
		}

		public ObjectUseOnCharacterMessage()
		{
		}

		public ObjectUseOnCharacterMessage(uint objectUID, double characterId) : base(objectUID)
		{
			this.characterId = characterId;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.characterId = reader.ReadVarUhLong();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarLong(this.characterId);
		}
	}
}