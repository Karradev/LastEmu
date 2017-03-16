using Protocol.IO;


using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class SpouseInformationsMessage : NetworkMessage
	{
		public const uint Id = 6356;

		public FriendSpouseInformations spouse;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6356;
			}
		}

		public SpouseInformationsMessage()
		{
		}

		public SpouseInformationsMessage(FriendSpouseInformations spouse)
		{
			this.spouse = spouse;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.spouse = ProtocolTypeManager.GetInstance<FriendSpouseInformations>(reader.ReadUShort());
			this.spouse.Deserialize(reader);
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteShort(this.spouse.TypeId);
			this.spouse.Serialize(writer);
		}
	}
}