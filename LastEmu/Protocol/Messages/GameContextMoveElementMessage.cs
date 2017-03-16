using Protocol.IO;

using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class GameContextMoveElementMessage : NetworkMessage
	{
		public const uint Id = 253;

		public EntityMovementInformations movement;

		public override uint ProtocolId
		{
			get
			{
				return (uint)253;
			}
		}

		public GameContextMoveElementMessage()
		{
		}

		public GameContextMoveElementMessage(EntityMovementInformations movement)
		{
			this.movement = movement;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.movement = new EntityMovementInformations();
			this.movement.Deserialize(reader);
		}

		public override void Serialize(IDataWriter writer)
		{
			this.movement.Serialize(writer);
		}
	}
}