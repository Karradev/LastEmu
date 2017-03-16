using Protocol.IO;

using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class GameContextMoveMultipleElementsMessage : NetworkMessage
	{
		public const uint Id = 254;

		public EntityMovementInformations[] movements;

		public override uint ProtocolId
		{
			get
			{
				return (uint)254;
			}
		}

		public GameContextMoveMultipleElementsMessage()
		{
		}

		public GameContextMoveMultipleElementsMessage(EntityMovementInformations[] movements)
		{
			this.movements = movements;
		}

		public override void Deserialize(IDataReader reader)
		{
			ushort num = reader.ReadUShort();
			this.movements = new EntityMovementInformations[num];
			for (int i = 0; i < num; i++)
			{
				this.movements[i] = new EntityMovementInformations();
				this.movements[i].Deserialize(reader);
			}
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteShort((short)((int)this.movements.Length));
			EntityMovementInformations[] entityMovementInformationsArray = this.movements;
			for (int i = 0; i < (int)entityMovementInformationsArray.Length; i++)
			{
				entityMovementInformationsArray[i].Serialize(writer);
			}
		}
	}
}